using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Fina.Core.Response
{
    public abstract class Response<TData>
    {
        private int _code = Configuration.DefaultStatusCode;

        [JsonConstructor]
        public Response() => _code = Configuration.DefaultStatusCode;

        //Optional parameters: code, message
        //Example: var res = new Response<Category> model;
        public Response(TData? data,
                             int code = Configuration.DefaultStatusCode,
                             string? message = null)
        {
            Data = data;
            _code = code;
            Message = message;
        }

        public TData? Data { get; set; }
        public string? Message { get; set; }

        [JsonIgnore]
        public bool IsSuccess => _code is >= 200 and <= 299;
    }
}
