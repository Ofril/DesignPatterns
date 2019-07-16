using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    // non touchable class
    // 3rd party
    // very old - chanigng it will be danger ....
    public class PerfectStore : IDBData
    {
        public void store(ClientData clientData)
        {
            Console.WriteLine("Client data shows nicely " + clientData.ToString());
        }
    }
}
