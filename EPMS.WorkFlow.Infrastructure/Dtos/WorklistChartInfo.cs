using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPMS.WorkFlow.Infrastructure.Dtos
{
    public class WorklistChartInfo
    {
        public int Pending { get; set; }

        public int WIP { get; set; }

        public int Cancelled { get; set; }


        public int Completed { get; set; }
    }
}
