using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba2020.Web.Models.Utils
{
    public class JsonResponse
    {
        public const int OK = 0;
        public const int ERROR = -1;

        public int code { get; set; }
        public object value { get; set; }

        public JsonResponse()
        {
            this.code = ERROR;
            this.value = null;
        }
    }
}