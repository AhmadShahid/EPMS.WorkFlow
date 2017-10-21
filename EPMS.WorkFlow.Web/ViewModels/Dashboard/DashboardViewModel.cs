using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPMS.WorkFlow.Infrastructure.Dtos;

namespace EPMS.WorkFlow.Web.ViewModels.Dashboard
{
    public class DashboardViewModel
    {
        public TileInfo Request { get; set; }
        public TileInfo Worklist { get; set; }
        public TileInfo Assignment { get; set; }

        public WorklistChartInfo WorklistChartInfo { get; set; }
    }
}