﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class SuperLaser
    {
        int laserPowerLevel = 100;
        int laserDamage = 100;
        int chargerPack = 100;
        
        public SuperLaser(int laserPowerLevel, int laserDamage, int chargerPack)
        {
            this.laserPowerLevel = laserPowerLevel;
            this.laserDamage = laserDamage;
            this.chargerPack = chargerPack;

        }

       

        public void FireLaser()
      
        {
            laserPowerLevel -= 5;
            Console.WriteLine("Pew, pew, pew!");
            
            if (laserPowerLevel <= 0)
            {
                Recharge();
            }
        }
        public void Recharge()
        {
            laserPowerLevel += chargerPack;
            Console.WriteLine("The Super Laser is recharging");
        }
        public void TripleShot()
        {
            laserPowerLevel -= 15;
            Console.WriteLine("PEW PEW PEW... PEW PEW PEW... PEW PEW PEW!!!");
            if (laserPowerLevel <= 0)
            {
                Recharge();
            }

        }

        public void ChargedShot()
        {
            Console.WriteLine("You fire a Charged Shot!  It does a tremendous amount of damage!");
                laserDamage += 100;
                laserPowerLevel -= 100;
            Console.WriteLine("The laser power level is now depleted.");
            
        }
    }
}
