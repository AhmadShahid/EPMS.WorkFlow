using EPMS.WorkFlow.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPMS.WorkFlow.Core.Common.Paging;
using EPMS.WorkFlow.Core.Common.Paging.SSI.Framework.Common.Paging;
using System.Linq.Expressions;
using EPMS.WorkFlow.Core.Context;
using System.Data.SqlClient;

namespace EPMS.WorkFlow.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected WorkFlowContext context;

        public Repository(WorkFlowContext context)
        {
            this.context = context;
        }
        public void Add(T entity)
        {
            this.context.Set<T>().Add(entity);
        }

        public void Edit(T entity)
        {
            this.context.Entry<T>(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public T Find(long id)
        {
            return this.context.Set<T>().Find(id);
        }

        public IList<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return this.context.Set<T>().Where(predicate).ToList();
        }

        public T Get(long id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            return this.context.Set<T>().ToList();
        }

        public PagedList<T> GetPaged(Expression<Func<T, bool>> expression, PagingInfo pagingInfo)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            this.context.Set<T>().Remove(entity);
        }

        public void RemoveById(long Id)
        {
            var db = this.context.Set<T>().Find(Id);

        }

        public virtual void Save()
        {
            this.context.SaveChanges();
        }
    }
}
