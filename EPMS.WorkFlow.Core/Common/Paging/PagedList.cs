using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPMS.WorkFlow.Core.Common.Paging
{
    public class PagedList<T>
    {
        public IEnumerable<T> data { get; set; }
        public int PageIndex { get; private set; }
        public int PageSize { get; private set; }
        public int recordsTotal { get; private set; }
        public int TotalPages { get; private set; }

        public bool HasPreviousPage
        {
            get { return (PageIndex > 1 && TotalPages > 0); }
        }
        public bool HasNextPage
        {
            get { return (PageIndex + 1 < TotalPages); }
        }

        public PagedList(IEnumerable<T> source, int pageIndex, int pageSize, int totalRows)
        {
            recordsTotal = totalRows;
            TotalPages = totalRows / pageSize;
            if (totalRows % pageSize > 0)
                TotalPages++;
            PageSize = pageSize;
            PageIndex = pageIndex;
            data = source.ToList();
        }
    }
}
