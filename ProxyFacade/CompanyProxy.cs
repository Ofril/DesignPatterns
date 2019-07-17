using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    public class CompanyProxy : ClientProxy, ICompany
    {
        public void CancelFlight()
        {
            flightSystemFacade.CancelFlight();
        }

        public void CreateFlight()
        {
            flightSystemFacade.CreateFlight();
        }
    }
}
