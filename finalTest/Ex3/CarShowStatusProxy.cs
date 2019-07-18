using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class CarShowStatusProxy : ICarShowStatus
    {
        protected CarSystemFacade carSystemFacade = new CarSystemFacade();

        public CarShowStatusProxy()
        {
        }

        public void ShowFuel()
        {
            carSystemFacade.ShowFuel();
        }

        public void ShowLocation()
        {
            carSystemFacade.ShowLocation();
        }
    }
}
