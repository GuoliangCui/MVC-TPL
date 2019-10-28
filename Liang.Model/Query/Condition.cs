using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Liang.Model.Query
{
    /// <summary>
    /// 条件查询
    /// </summary>
    public class Condition
    {
        private List<Column> _columns = null;
        private PageInfo _page = null;
        private string _sort = null;
        public PageInfo PageInfo { get { return this._page; } set { this._page = value; } }
        public string Sort { get { return this._sort; } set { this._sort = value; } }

        public Condition(List<Column> columns = null, PageInfo page = null, string sort = "Id ASC")
        {
            if (columns == null)
            {
                columns = new List<Column>();
            }
            this._columns = columns;
            this._page = page;
            this._sort = sort;

        }
        public void Add(Column column)
        {
            this._columns.Add(column);
        }
        /// <summary>
        /// 获取sql语句
        /// </summary>
        /// <param name="pagination">是否分页(默认不分页)</param>
        /// <returns></returns>
        public string GetSql(bool pagination=false)
        {
            var whereSql = " where 1=1 ";

            //循环_fields 添加到 param

            var columnsGroup = _columns.GroupBy(o => o.Group);

            if (columnsGroup.Count() != 1)
            {
                foreach (var group in columnsGroup)
                {
                    whereSql += $"{group.Where(o=>o.GroupLogic!=null).FirstOrDefault().GroupLogic} (";
                    var index = 0;
                    foreach (var column in group)
                    {
                        var LogicName = index == 0 ? "" : $" {column.Logic}";
                        whereSql += $"{LogicName} {column.Name} {column.Operator} @{column.Name} ";
                        index++;
                    }
                    whereSql += ") ";
                }
            }
            else {
                foreach (var column in _columns)
                {
                    whereSql += $" {column.Logic} {column.Name} {column.Operator} @{column.Name} ";
                }
            }

            if (!string.IsNullOrEmpty(Sort))
            {
                whereSql += $" order by {Sort} ";
            }

            if (pagination)
            {
                whereSql += $" limit @PageIndex,@PageSize";
            }
           

            return whereSql.ToUpper();
        }

        /// <summary>
        /// 获取sql参数信息
        /// </summary>
        /// <param name="pagination">是否分页(默认不分页)</param>
        /// <returns></returns>
        public DynamicParameters GetParameters(bool pagination = false)
        {
            var param = new DynamicParameters();

            //循环_fields 添加到 param

            foreach (var column in _columns)
            {
                param.Add(column.Name, column.Value);
            }
            if (pagination)
            {
                param.Add("PAGEINDEX", (PageInfo.PageIndex-1)*PageInfo.PageSize);
                param.Add("PAGESIZE", PageInfo.PageIndex);
            }
            return param;
        }


    }
}
