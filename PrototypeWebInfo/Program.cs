using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeWebInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.IntelliTect.com";
            string url2 = "http://www.IntelliTect.com";
            string url3 = "http://www.Blabla.com";
            WebInfoFactory webInfoFactory = new WebInfoFactory();

            Console.WriteLine(url);
            Console.WriteLine(webInfoFactory.CreateWebInfo(url).ToString());
            Console.WriteLine(url2);
            Console.WriteLine(webInfoFactory.CreateWebInfo(url2).ToString());
            Console.WriteLine(url3);
            Console.WriteLine(webInfoFactory.CreateWebInfo(url3).ToString());
            Console.WriteLine();
        }
    }
}