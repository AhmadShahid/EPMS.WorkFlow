using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPMS.WorkFlow.Core.Context;
using EPMS.WorkFlow.Core.IRepository;

namespace EPMS.WorkFlow.Infrastructure.Repository
{
    public class ExecStoreProcedure : IExecStoreProcedure
    {

        protected WorkFlowContext context;

        public ExecStoreProcedure(WorkFlowContext context)
        {
            this.context = context;
        }

        public IList<T> ExecTilesStoredProcedure<T>(int UserId)
        {
            var idParam = new SqlParameter
            {
                ParameterName = "@UserId",
                Value = UserId,
                DbType = System.Data.DbType.Int32
            };
            return this.context.Database.SqlQuery<T>(
            "exec [dbo].[EPMS_GetTileInfo] @UserId ", idParam).ToList();
        }


        public T ExecWorklistStoredProcedure<T>(int UserId)
        {
            var idParam = new SqlParameter
            {
                ParameterName = "@UserId",
                Value = UserId,
                DbType = System.Data.DbType.Int32
            };
            return this.context.Database.SqlQuery<T>(
            "exec [dbo].[EPMS_GetWorklistStatus] @UserId ", idParam).SingleOrDefault();
        }
    }
}
