using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class CarSystemFacade : ICarActions, ICarShowStatus
    {
        CarsDAO carsDao = new CarsDAO();

        public void StartDrive()
        {
            carsDao.StartDriving();
        }

        public void EndDrive()
        {
            carsDao.EndDriving();
        }

        public void IncreaseSpeed()
        {
            carsDao.IncreaseSpeedOfCar();
        }

        public void DecreaseSpeed()
        {
            carsDao.DecreaseSpeedOfCar();
        }

        public void TurnRight()
        {
            carsDao.TurningRight();
        }

        public void TurnLeft()
        {
            carsDao.TurningLeft();
        }

        public void ShowFuel()
        {
            carsDao.ShowFuelState();
        }

        public void ShowLocation()
        {
            carsDao.ShowLocation();
        }
    }
}
