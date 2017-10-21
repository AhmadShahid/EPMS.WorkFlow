using EPMS.WorkFlow.Core.Entities;
using EPMS.WorkFlow.Core.Identity;

using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPMS.WorkFlow.Core.Migrations;

namespace EPMS.WorkFlow.Core.Context
{
    public class WorkFlowContext : IdentityDbContext<ApplicationUser>
    {

        public WorkFlowContext() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WorkFlowContext, Configuration>());
        }

        public DbSet<MaintenanceRequest> MaintenanceRequests { get; set; }

        public DbSet<MaintenanceWorklist> MaintenanceWorklists { get; set; }

        public static WorkFlowContext Create()
        {
            return new WorkFlowContext();
        }

    }
}
