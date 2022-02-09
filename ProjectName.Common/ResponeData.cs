using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectName.Common
{
    public class ResponeData
    {
        public int resultNumber { set; get; }
        public Error error { set; get; }

    }
    public class Error
    {
        public int code { set; get; } = 200;
        public string message { set; get; } = "";
        public Error(int code =200, string message = "")
        {
            this.code = code;
            this.message = message;
        }
    }
}
