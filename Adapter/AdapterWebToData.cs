using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AdapterWebToData : IDBWebData
    {

        IDBData idbData = new PerfectStore();

        public void store(WebClientData webClientData)
        {
            idbData.store(webClientData.GetClientData());
        }
    }
}
