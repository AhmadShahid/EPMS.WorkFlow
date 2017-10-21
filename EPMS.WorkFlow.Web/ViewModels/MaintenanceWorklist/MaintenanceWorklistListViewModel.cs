using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPMS.WorkFlow.Web.ViewModels.MaintenanceWorklist
{
    public class MaintenanceWorklistListViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ExpiryDate{ get; set; }

        public string IsCompleted { get; set; }

        public string Status { get; set; }
    }
}