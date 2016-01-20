using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class TractorBeam : Reactor
    {
         int TractorBeamLevel
        {
            set
            {
                TractorBeamLevel = value;
            }
            get
            {
                return TractorBeamLevel;
            }
        }
        public TractorBeam(int PowerRate, int TractorBeamLevel)
            :base(PowerRate)
        {
            this.TractorBeamLevel = TractorBeamLevel;
        }
         void Tractorbeamgeneratortower(int powerrate)
            
        {
            TractorBeamLevel = powerrate;
                       
        }

         void GenerateTractorBeam()
        {
            TractorBeamLevel++;
        }

         void CreateForce(int power, int direction)
        {
            Tractorbeamgeneratortower(power);
            //Console.WriteLine($"Your tractor bean starts pulling with {power} at {direction} degrees");
        }
    }
}
