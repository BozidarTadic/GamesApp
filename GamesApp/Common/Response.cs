using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace GamesApp.Common
{
    public class Response<T> : IResponse<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public T Content { get; set; }
        public List<ErrorResult> ErrorMessage { get; set; }
    }
    public class NoValue
    {

    }
}
