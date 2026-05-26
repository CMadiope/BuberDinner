using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BuberDinner.Application.Common.Errors
{
    public interface IServiceException
    {
        public string ErrorMessage { get; }
        public HttpStatusCode StatusCode { get; }
    }
}