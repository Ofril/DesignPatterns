using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespLoggerHandler
{
    class ErrorHandler : LogHandlerBase
    {
        protected const int LEVEL = 2;
        public override void Handle(string log, int level)
        {
            if (level == LEVEL)
            {
                Console.WriteLine("error: " + log);
            }
            else if (next != null)
            {
                next.Handle(log, level);
            }
        }
    }
}
