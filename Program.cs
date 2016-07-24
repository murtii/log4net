using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;


[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace ConsoleforExtraProject
{
    class Program
    {
          private static readonly log4net.ILog log = log4net.LogManager.GetLogger
         (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
             log.Fatal("Fatal error occured");
             log.Info("This is an info message");

        }
    }
}

