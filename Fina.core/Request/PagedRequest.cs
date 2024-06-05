using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Request
{
    public abstract class PagedRequest
    {
        public ushort PageSize { get; set; } = Configuration.DefaultPageSize;
        public ushort PageNumber { get; set; } = Configuration.DefaultPageNumber;
    }
}
