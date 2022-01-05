using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace GamesApp.Common
{
    public interface IResponse<T>
    {
        HttpStatusCode StatusCode { get; set; }
        T Content { get; set; }
        List<ErrorResult> ErrorMessage { get; set; }
    }
}
