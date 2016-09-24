using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Logic
{
    public interface IVehicle
    {
        int GetSpeed();
        void IncreaseSpeed(int amount);
        void DecreaseSpeed(int amount);
    }
}
