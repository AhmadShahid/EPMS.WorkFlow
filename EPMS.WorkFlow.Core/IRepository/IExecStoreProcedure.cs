using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPMS.WorkFlow.Core.Entities;

namespace EPMS.WorkFlow.Core.IRepository
{
    public interface IExecStoreProcedure 
    {
        IList<T> ExecTilesStoredProcedure<T>(int UserId);

        T ExecWorklistStoredProcedure<T>(int UserId);

    }
}
