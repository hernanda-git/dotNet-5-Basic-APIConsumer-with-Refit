using APIConsumerWithRefit.Model.Request;
using APIConsumerWithRefit.Model.Response;
using APIConsumerWithRefit.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using APIConsumerWithRefit.Services;
using Refit;
using APIConsumerWithRefit.Interface;
using APIConsumerWithRefit.Common;

namespace APIConsumerWithRefit.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var Authentication = RestService.For<IUserEntity>(BaseConnection.TargetAPI);
            var token_response = await Authentication.request_token(new TokenRequest { username = "hernanda", password = "hernanda" });
            return View();


            //Task<TokenResponse> User = request_token(new TokenRequest { username = "hernanda" , password = "hernanda"});

            //if (!string.IsNullOrEmpty(HttpContext.Session.GetString("_fullName")))
            //{
            //    string fullName = HttpContext.Session.GetString("_fullName");

            //    ViewBag.fullName = fullName;
            //}
            //else
            //{
            //    return RedirectToAction("Index", "login");
            //}
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
