using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Fina.Core.Response
{
    public class PagedResponse<TData> : Response<TData>
    {
        [JsonConstructor]
        public PagedResponse(TData? data,
                             ushort totalCount,
                             ushort curruntPage = 1,
                             ushort pageSize = Configuration.DefaultPageSize)
                             :base(data)
        {
            Data = data;
            TotalCount = totalCount;
            CurrentPage = curruntPage;
            PageSize = pageSize;
        }

        public PagedResponse(TData? data,
                             int code = Configuration.DefaultStatusCode,
                             string? message = null)
                             : base(data, code, message)
        {
            
        }

        public ushort CurrentPage { get; set; }
        public ushort TotalPages => (ushort)Math.Ceiling(TotalCount / (double)PageSize);
        public ushort PageSize { get; } = Configuration.DefaultPageSize;
        public ushort TotalCount { get; set; }
    }
}
