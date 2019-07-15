using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespLoggerHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            LogHandlerBase debugHandler = new DebugHandler();
            LogHandlerBase infoHandler = new InfoHandler();
            LogHandlerBase errorHandler = new ErrorHandler();
            LogHandlerBase fatalHandler = new FatalHandler();


            LogHandlerBase chainRoot = debugHandler;
            debugHandler.SetNext(infoHandler);
            infoHandler.SetNext(errorHandler);
            errorHandler.SetNext(fatalHandler);

            Console.WriteLine("Some error log", 2);
            chainRoot.Handle("Some error log", 2);
            Console.WriteLine("==================");
            Console.WriteLine("Some fatal log", 1);
            chainRoot.Handle("Some fatal log", 1);
            Console.WriteLine("==================");
            Console.WriteLine("Some debug log", 4);
            chainRoot.Handle("Some debug log", 4);
            Console.WriteLine("==================");
            Console.WriteLine("Some info log", 3);
            chainRoot.Handle("Some info log", 3);
            Console.WriteLine("==================");

            LogHandlerBase chainRoot2 = fatalHandler;
            fatalHandler.SetNext(errorHandler);
            errorHandler.SetNext(infoHandler);
            infoHandler.SetNext(debugHandler);

            Console.WriteLine("Some error log", 2);
            chainRoot2.Handle("Some error log", 2);
            Console.WriteLine("==================");
            Console.WriteLine("Some fatal log", 1);
            chainRoot2.Handle("Some fatal log", 1);
            Console.WriteLine("==================");
            Console.WriteLine("Some debug log", 4);
            chainRoot2.Handle("Some debug log", 4);
            Console.WriteLine("==================");
            Console.WriteLine("Some info log", 3);
            chainRoot2.Handle("Some info log", 3);
            Console.WriteLine("==================");
        }
    }
}
