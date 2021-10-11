using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFFirst
{

    public class FirstWCFCODE1 : IFirstWCFCODE1
    {
        public string Message()
        {
            return "Hello, This is my first web service";
        }
    }
}
