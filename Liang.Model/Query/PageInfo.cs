using System;
using System.Collections.Generic;
using System.Text;

namespace Liang.Model.Query
{
    /// <summary>
    /// 分页信息
    /// </summary>
    public class PageInfo
    {
        private int _pageIndex;
        private int _pageSize;
        public PageInfo(int pageIndex = 1, int pageSize = 10)
        {
            this._pageIndex = pageIndex;
            this._pageSize = PageSize;
        }
        public int PageIndex { get { return this._pageIndex; } set { this._pageIndex = value; } }
        public int PageSize { get { return this._pageSize; } set { this._pageSize = value; } }
        public int TotalCount { get; set; }
    }
}
