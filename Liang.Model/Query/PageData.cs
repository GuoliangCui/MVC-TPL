using System;
using System.Collections.Generic;
using System.Text;

namespace Liang.Model.Query
{
    /// <summary>
    /// 分页容器
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PageData<T>
    {
        /// <summary>
        /// 分页信息
        /// </summary>
        public PageInfo PageInfo { get; set; }
        public IList<T> Result { get; set; }
    }
}
