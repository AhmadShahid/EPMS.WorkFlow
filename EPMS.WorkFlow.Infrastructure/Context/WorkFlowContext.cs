using EPMS.WorkFlow.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPMS.WorkFlow.Infrastructure.Context
{
    public class WorkFlowContext : DbContext
    {

        public WorkFlowContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<MaintenanceRequest> MaintenanceRequests { get; set; }

        public DbSet<MaintenanceWorklist> MaintenanceWorklists { get; set; }

    }
}
