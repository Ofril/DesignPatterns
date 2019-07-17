using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyFactory proxyFactory = new ProxyFactory();
            ClientProxy clientProxy = proxyFactory.Login("Ofri", "1");
            ((CustomerProxy)clientProxy).BuyTicket();
            ((CustomerProxy)clientProxy).ShowTickets();
            clientProxy = proxyFactory.Login("Elal", "2");
            ((CompanyProxy)clientProxy).CreateFlight();
            ((CompanyProxy)clientProxy).CancelFlight();
            clientProxy = proxyFactory.Login("Admin", "3");
            ((AdminProxy)clientProxy).CreateCompany();
            ((AdminProxy)clientProxy).CreateCustomer();
        }
    }
}
