using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIConsumerWithRefit.Model.Request
{
    public class TokenRequest
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
