
namespace Liang.DAL
{
    using Liang.Model.Query;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// DAL接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDAL<T> where T : class
    {
        void Insert(T model);
        void Delete(long id);
        void Update(T model);
        T Get(long id);
        IList<T> GetList(Condition condition=null);
        PageData<T> GetList(PageInfo pageInfo,Condition condition = null);
    }
}
