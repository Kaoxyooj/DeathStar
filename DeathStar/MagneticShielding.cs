using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class MagneticShielding
    {
         int energy = 100;
         int minMagShieldBuff = 1;
         int maxMagShieldBuff = 4;
         int enemyMinDMG = 30;
         int enemyMaxDMG = 60;
         int shieldGone = 0;


        public int enemyDamage()
        {
            Random incoming = new Random();
            int IncomingDMG = incoming.Next(enemyMinDMG, enemyMaxDMG);
            return IncomingDMG;
        }



        public int energyBuff()
        {
            Random randomShieldBuff = new Random();
            int MSbuff = randomShieldBuff.Next(minMagShieldBuff, maxMagShieldBuff);
            return MSbuff;
        }

        public int protect(int IncomingDMG, int MSbuff)
        {
            int eLevel = (MSbuff * energy);
            
             eLevel = IncomingDMG - eLevel;

            return eLevel;
        }

        public void isShieldDepleted(int eLevel)
        {
            if (eLevel <= shieldGone)
            {
                Console.WriteLine("shield is gone");
            }
            else
            {
                Console.WriteLine("you stile have a shield");
            }

              
        }
        
    }
}
