using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class IonDriveReactor : Reactor
    {
        public int CriticalDriveRate = 1;
        public int HalfDriveRate = 2;
        public int IonDriveRate = 4;
        public int IonDriveHealthStatus
        {
            get
            {
                return IonDriveHealthStatus;
            }
           set { value = 100; }
        }
        public int CriticalHealth = 25;
        public int HalfHealth = 50;
        public int FullHealth = 100;
         IonDriveReactor(int PowerRate, int IonDriveHealth = 100) : base(PowerRate) 
        {
            this.IonDriveHealthStatus = IonDriveHealth;
        }
        public int ChargeIonDrive()
        {
            if(IonDriveHealthStatus == FullHealth)
            {
                return PowerRate * IonDriveRate;
            }
            else if(IonDriveHealthStatus >= HalfHealth)
            {
                return PowerRate * (IonDriveRate / HalfDriveRate);
            }
            else if(IonDriveHealthStatus == 0)
            {
                return PowerRate * CriticalDriveRate;
            }
            return PowerRate;    
        }
    }
}
