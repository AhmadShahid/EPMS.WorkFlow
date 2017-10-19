using EPMS.WorkFlow.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPMS.WorkFlow.Core.Common.Paging;
using EPMS.WorkFlow.Core.Common.Paging.SSI.Framework.Common.Paging;
using System.Linq.Expressions;

namespace EPMS.WorkFlow.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T>
    {
        public bool Delete(params T[] data)
        {
            throw new NotImplementedException();
        }

        public T Get(long id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public PagedList<T> GetPaged(Expression<Func<T, bool>> expression, PagingInfo pagingInfo)
        {
            throw new NotImplementedException();
        }
    }
}
