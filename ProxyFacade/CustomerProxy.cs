using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    public class CustomerProxy : ClientProxy, ICustomer
    {
        public void BuyTicket()
        {
            flightSystemFacade.BuyTicket();
        }

        public void ShowTickets()
        {
            flightSystemFacade.ShowTickets();
        }
    }
}
