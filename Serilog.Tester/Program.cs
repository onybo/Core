using Castle.Facilities.Logging;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serilog.Tester
{
    using Castle.MicroKernel.Registration;
    using Castle.Services.Logging.SerilogIntegration;
    using log4net.Config;

    class Program
    {
        static void Main(string[] args)
        {
            //log.Error("Hello logger");
            //log.Warning("Hello logger");
            //BasicConfigurator.Configure();
            var container = new WindsorContainer();
            container.AddFacility<LoggingFacility>(f => f.LogUsing<SerilogFactory>());
            container.Register(Classes.FromThisAssembly()
                .Pick()
                .LifestyleTransient());
            var service = container.Resolve<CustomerService>();
            service.SayHello();

            var log = new LoggerConfiguration()
    .WriteTo.ColoredConsole()
    .CreateLogger().ForContext("type", "this.is.a.type");

            log.Information("Hello seri logger {type}");


            Console.ReadKey();
        }
    }
}
