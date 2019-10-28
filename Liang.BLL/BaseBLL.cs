using Liang.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Liang.BLL
{
    public class BaseBLL<T,D>where T:class where D:IDAL<T>,new()
    {
        protected D dal = new D();
        
        public virtual void Insert(T model)
        {
            dal.Insert(model);
        }
        public virtual void Delete(long id)
        {
            dal.Delete(id);
        }
        public virtual void Update(T model)
        {
            dal.Update(model);
        }
        public virtual T Get(long id)
        {
            return dal.Get(id);
        }
    }
}
