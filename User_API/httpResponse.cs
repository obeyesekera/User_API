using System;
using System.Collections.Generic;
using System.Text;

namespace User_API
{
    internal class httpResponse
    {
        public int status { get; set; }
        public object data { get; set; }
        public string message { get; set; }
    }
}
