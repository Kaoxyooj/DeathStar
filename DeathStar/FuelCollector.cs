using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
     public class FuelCollector
    {
         int tankSizeInGallons;
         bool isTankFull;

         FuelCollector(int TankSizeInGallons)
        {
            tankSizeInGallons = TankSizeInGallons;
        }
         void fuelTankStatus()
        {
            Console.WriteLine("Fuel status");
        }
    }
}
