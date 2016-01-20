using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class Exhaust
    {
        public readonly int Diameter;
        public readonly int Length;
        public readonly int numberOfFans;
        
        public Exhaust()
        {

        }
        public Exhaust(int diameter, int length, int numberOfFans)
        {
            this.Diameter = diameter;
            this.Length = length;
            this.numberOfFans = numberOfFans;
        }
        public bool isOpen;

        public virtual Radiation ExpendExhaust()
        {
            return null;
        }
    }
}
