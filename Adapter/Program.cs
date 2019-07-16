using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClientData webClientData = new WebClientData("Ofri", 24, "100.180.1.12", true);

            store(new AdapterWebToData(), webClientData);
        }

        // non mutable
        private static void store(IDBWebData idb, WebClientData webClientData)
        {
            idb.store(webClientData);
        }
    }
}
