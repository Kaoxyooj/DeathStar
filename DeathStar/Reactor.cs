using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class Reactor
    {
        public int PowerRate
		{
			 set
			{
				PowerRate = value;
			}
			get
			{
				return PowerRate;
			}
		}
        public int InitialPowerPercent = 0;
         int MaxPowerPercent = 100;

        public Reactor(int PowerRate)
        {
            this.PowerRate = PowerRate;
        }

        public void theReactor(int powerRate)
        {
            PowerRate = powerRate;
        }

        int GeneratePower()
        {
            if(InitialPowerPercent <= MaxPowerPercent)
            {
                PowerRate++;
            }
            return PowerRate;
        }
    }
}
