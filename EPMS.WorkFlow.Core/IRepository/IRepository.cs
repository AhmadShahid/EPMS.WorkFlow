using EPMS.WorkFlow.Core.Common.Paging;
using EPMS.WorkFlow.Core.Common.Paging.SSI.Framework.Common.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EPMS.WorkFlow.Core.IRepository
{
    public interface IRepository<T>
    {
        T Find(long id);
        IList<T> FindBy(Expression<Func<T, bool>> predicate);
        IList<T> GetAll();
        PagedList<T> GetPaged(Expression<Func<T, bool>> expression, PagingInfo pagingInfo);

        void Remove(T entity);

        void RemoveById(long Id);


        void Add(T entity);
        void Edit(T entity);

        void Save();

     
    }
}
