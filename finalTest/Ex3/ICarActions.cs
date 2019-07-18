using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public interface ICarActions
    {
        void StartDrive();

        void EndDrive();

        void IncreaseSpeed();

        void DecreaseSpeed();

        void TurnRight();

        void TurnLeft();
    }
}
