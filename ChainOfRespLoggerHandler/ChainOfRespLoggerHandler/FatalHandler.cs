using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespLoggerHandler
{
    public class FatalHandler : LogHandlerBase
    {
        private const int LEVEL = 1;
        public override void Handle(string log, int level)
        {
            if (level == LEVEL)
            {
                Console.WriteLine("fatal: " + log);
            }
            else if (next != null)
            {
                next.Handle(log, level);
            }
        }
    }
}
