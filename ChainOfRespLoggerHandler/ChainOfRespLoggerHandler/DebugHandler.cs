using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespLoggerHandler
{
    public class DebugHandler : LogHandlerBase
    {
        protected const int LEVEL = 4;
        public override void Handle(string log, int level)
        {
            if (level == LEVEL)
            {
                Console.WriteLine("debug: " + log);
            }
            else if (next != null)
            {
                next.Handle(log, level);
            }
        }
    }
}
