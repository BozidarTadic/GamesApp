using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesApp.Common
{
    public class Message
    {
        public static List<ErrorResult> InternalServerError = new List<ErrorResult>
        {
            new ErrorResult
            {
                ErrorCode = "Internal server error",
                ErrorDescription = "Internal server error."
            }
        };

    }
}
