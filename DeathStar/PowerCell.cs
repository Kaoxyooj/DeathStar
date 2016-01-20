using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{

    public class PowerCell
    {
        int cell = 0;
        int powerLevel;
         void powerCell()
        {
            this.powerLevel = 100;
        }
         void LosePower()
        {
            powerLevel--;
        }
         void checkPowerLevel()
        {
            Console.WriteLine("The power level is ", powerLevel);
        }
         void replaceDefCell()
        {
            this.powerLevel = 100;
        }
    }
}
