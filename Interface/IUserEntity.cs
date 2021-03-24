using APIConsumerWithRefit.Model.Request;
using APIConsumerWithRefit.Model.Response;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIConsumerWithRefit.Interface
{
    public interface IUserEntity
    {
        [Post("/api/Authenticate/token")]
        Task<TokenResponse> request_token([Body] TokenRequest request);
    }
}
