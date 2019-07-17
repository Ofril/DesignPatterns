using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    public class ProxyFactory
    {
        private const string CUSTOMER_USERNAME = "Ofri";
        private const string CUSTOMER_PASSWORD = "1";
        private const string COMPANY_USERNAME = "Elal";
        private const string COMPANY_PASSWORD = "2";
        private const string ADMIN_USERNAME = "Admin";
        private const string ADMIN_PASSWORD = "3";

        public ClientProxy Login(string user, string pass)
        {
            if (user.Equals(CUSTOMER_USERNAME) && pass.Equals(CUSTOMER_PASSWORD))
            {
                return new CustomerProxy();
            }
            else if (user.Equals(COMPANY_USERNAME) && pass.Equals(COMPANY_PASSWORD))
            {
                return new CompanyProxy();
            }
            else if (user.Equals(ADMIN_USERNAME) && pass.Equals(ADMIN_PASSWORD))
            {
                return new AdminProxy();
            }

            throw new Exception("wrong user/pass");
        }
    }
}
