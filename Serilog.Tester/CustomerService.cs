using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serilog.Tester
{
    using Castle.Core.Logging;

    public class CustomerService
    {
        private ILogger logger = NullLogger.Instance;

        public CustomerService()
        {
        }

        public ILogger Logger
        {
            get { return logger; }
            set { logger = value; }
        }

        public void SayHello()
        {
            logger.Error("test");
            logger.Warn("test warning");
        }
    }
}
