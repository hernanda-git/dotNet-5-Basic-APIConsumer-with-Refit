using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIConsumerWithRefit.Common
{
    public class BaseConnection
    {
        public static string TargetAPI => "https://localhost:44338/";
        public static Uri TargetAPIUri => new Uri("https://localhost:44338/");
    }
}
