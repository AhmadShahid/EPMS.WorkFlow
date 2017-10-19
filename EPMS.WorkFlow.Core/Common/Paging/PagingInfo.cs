using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPMS.WorkFlow.Core.Common.Paging
{
    namespace SSI.Framework.Common.Paging
    {
        public class PagingInfo
        {
            public int PageIndex { get; set; }
            public int PageSize { get; set; }
            public string OrderBy { get; set; }
            public OrderDirection OrderDirection { get; set; }
        }
    }

}
