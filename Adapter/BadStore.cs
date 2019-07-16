using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class BadStore : IDBWebData
    {

        public void store(WebClientData webClientData)
        {
            Console.WriteLine("Web client data is not so nice ... " + webClientData.ToString());

        }
    }

}