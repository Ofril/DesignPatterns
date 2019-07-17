using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    public class AdminProxy : ClientProxy, IAdmin
    {
        public void CreateCompany()
        {
            flightSystemFacade.CreateCompany();
        }

        public void CreateCustomer()
        {
            flightSystemFacade.CreateCustomer();
        }
    }
}
