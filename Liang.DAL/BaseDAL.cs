using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Liang.Model.Query;
using Dapper;

namespace Liang.DAL
{
    public class BaseDAL
    {
        private static IDbConnection GetConn()
        {
            //从配置文件中获取链接字符串
            string connStr = "";
            MySqlConnection conn = new MySqlConnection(connStr);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;

        }
        public int Execute(string sql, object param = null)
        {
            using (var conn = GetConn())
            {
                return conn.Execute(sql, param);
            }
        }
        public T QueryFirstOrDefault<T>(string sql, object param = null)
        {
            using (var conn = GetConn())
            {
                return conn.QueryFirstOrDefault<T>(sql, param);
            }
        }
        public IList<T> Query<T>(string sql, object param = null)
        {
            using (var conn = GetConn())
            {
                var p = new DynamicParameters();
                p.Add("", "");

                return (IList<T>)conn.Query<T>(sql, param);
            }
        }

        /// <summary>
        /// 条件查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public IList<T> QueryByCondition<T>(string sql, Condition condition = null)
        {
            if (condition == null)
                return Query<T>(sql);
            else
                return Query<T>(sql + condition.GetSql(), condition.GetParameters());
        }
        /// <summary>
        /// 分页查询+条件查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="pageInfo"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public PageData<T> QueryByPageCondition<T>(string sql, PageInfo pageInfo, Condition condition = null)
        {
            PageData<T> pageData = new PageData<T>();
            if (condition == null)
            {
                condition = new Condition(null, pageInfo);
            }
            using (var conn = GetConn())
            {
                var sqlAll = $" {sql + condition.GetSql()} ; {sql + condition.GetSql(true)} ";
                var results= conn.QueryMultiple(sqlAll, condition.GetParameters());
                var totalCount= results.ReadFirstOrDefault<int>();
                //数据信息
                var data = (IList<T>)results.Read<T>();

                //分页信息
                pageData.Result = data;
                pageInfo.TotalCount = totalCount;
                pageData.PageInfo = pageInfo;
            }

            return pageData;
        }
    }
}
