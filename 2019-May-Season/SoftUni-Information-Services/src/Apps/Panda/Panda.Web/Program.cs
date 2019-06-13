using SIS.MvcFramework;
using System;
using System.Globalization;
using System.Threading;

namespace Panda.Web
{
    public class Program
    {
        static void Main()
        {
            //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            WebHost.Start(new Startup());
        }
    }
}
