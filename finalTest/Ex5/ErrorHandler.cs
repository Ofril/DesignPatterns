﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class ErrorHandler : LogHandlerBase
    {
        protected const int LEVEL = 2;
        public override void Handle(string log, int level)
        {
            if (level == LEVEL)
            {
                Console.WriteLine("ERROR: " + log);
                WriteToFile(log);

            }
            else if (next != null)
            {
                next.Handle(log, level);
            }
        }
 
        private void WriteToFile(string log)
        {
            Console.WriteLine("Writing error to file...");
            File.AppendAllText(@"c:\Users\HackerU\source\repos\finalTest\Ex5\Ex5\log.txt", "ERROR: " + log + Environment.NewLine);
        }
    }
}
