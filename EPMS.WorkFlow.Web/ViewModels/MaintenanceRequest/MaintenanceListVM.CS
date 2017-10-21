using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPMS.WorkFlow.Web.ViewModels.MaintenanceRequest
{
    public class MaintenanceListVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }

        public string RequestBy { get; set; }
    }
}