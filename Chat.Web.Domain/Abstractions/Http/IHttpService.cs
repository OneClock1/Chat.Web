using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Web.Domain.Abstractions.Http
{
    interface IHttpService
    {
        Task<TOut> GetAsync<TOut>(string endpoint);
    }
}
