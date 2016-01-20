using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSecretPlans;

namespace DeathStar
{
    public class DeathStar
    {
        Mainexhaustport  mainExhaustPort;
        Thermalexhaustport ThermalExhaustPort;
        TractorBeam tractorBeam;
        MainPowerGenerator mainPowerGenerator;
        HyperMatterReactor hyperMatterReactor;
        IonDriveReactor ionDriveReactor;
        OverBridge overBridge;
        SuperLaser superLaser;
        MagneticShielding magneticShielding;
        HyperDrive hyperDrive;
        PowerCell powerCell;
        CentralComputerCore centralComputerCore;
        HeatExchanger heatExchanger;
        CoolingSystem coolingSystem;
        Refinery refinery;
        FuelCollector fuelCollector;
        ExteriorQuadaniumsteelouterhull exteriorQuadaniumSteelOuterHull;

        
        public void OffenseMode()
        {
            OffenseMode offense = new OffenseMode();
            offense.CheckMode();
            

        }
        public void Superlaser()
        {
            SuperLaser laser = new SuperLaser(100, 100, 100);
            laser.Recharge();
            laser.ChargedShot();                      
        }
        
        public void CentralCore()
        {           
            CentralComputerCore core = new CentralComputerCore("target",100,"");
            core.Activate();
            core.Refresh();
            core.targetEnemy();
        }
    }
}
