using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class CarsDAO
    {
       public void StartDriving()
        {
            Console.WriteLine("start driving... ");
        }

        public void EndDriving()
        {
            Console.WriteLine("end driving... ");
        }

        public void IncreaseSpeedOfCar()
        {
            Console.WriteLine("increasing the car speed... ");
        }

        public void DecreaseSpeedOfCar()
        {
            Console.WriteLine("decreasing the car speed... ");
        }

        public void TurningRight()
        {
            Console.WriteLine("turning to the right ");
        }

        public void TurningLeft()
        {
            Console.WriteLine("turning to the left ");
        }

        public void ShowFuelState()
        {
            Console.WriteLine("showing the fuel state ");
        }

        public void ShowLocation()
        {
            Console.WriteLine("showing my location ");
        }
    }
}
