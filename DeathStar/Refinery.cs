using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class Refinery
    {
         bool isOperating;
         int RefineFuel(int RawMaterials, int FuelRequested)
        {
            int someRawMaterials = 100;
            int someFuelRequested = someRawMaterials / 2;
            return someFuelRequested;
        }
         void Exhaust(int FuelRequested)
        {
            int theFuelRequested = RefineFuel(100, 50);
        }
    }
}
