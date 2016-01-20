using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class Thermalexhaustport : Exhaust, IChangeTemperature
    {
         int Temperature;

        public Radiation ExpendExhaust(ReactorCore core)
        {
            core.CoolDown();
            this.HeatUp();
            return new Radiation();
        }
         void HeatUp()
        {
             this.Temperature++;
        }
        
         void CoolDown()
        {
             this.Temperature--;
        }

        void IChangeTemperature.CoolDown()
        {
            throw new NotImplementedException();
        }

        void IChangeTemperature.HeatUp()
        {
            throw new NotImplementedException();
        }
    }
}
