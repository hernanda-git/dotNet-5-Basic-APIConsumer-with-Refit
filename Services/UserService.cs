using HttpClientDiagnostics;
using APIConsumerWithRefit.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Refit;
using APIConsumerWithRefit.Model.Response;
using APIConsumerWithRefit.Interface;
using APIConsumerWithRefit.Model.Request;

namespace APIConsumerWithRefit.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;
        private readonly IUserEntity _userEntity;

        public UserService(Uri BaseConnection)
        {
            _httpClient = new HttpClient(new HttpClientDiagnosticHandler(new HttpClientHandler())) { BaseAddress = BaseConnection };
            _userEntity = RestService.For<IUserEntity>(_httpClient);
        }

        public async Task<TokenResponse> request_token(TokenRequest request)
        {
            return await _userEntity.request_token(request).ConfigureAwait(false);
        }

    }
}
