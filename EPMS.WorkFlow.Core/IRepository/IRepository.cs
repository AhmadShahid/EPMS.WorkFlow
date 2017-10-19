using EPMS.WorkFlow.Core.Common.Paging;
using EPMS.WorkFlow.Core.Common.Paging.SSI.Framework.Common.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EPMS.WorkFlow.Core.IRepository
{
    public interface IRepository<T>
    {
        T Get(long id);
        IList<T> GetAll();
        PagedList<T> GetPaged(Expression<Func<T, bool>> expression, PagingInfo pagingInfo);

        bool Delete(params T[] data);
    }
}
