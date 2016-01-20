using DeathStar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class CentralComputerCore : IActivate
    {
        string command;
        int computerPower= 100;
        int coreHealth = 100;
        int shieldHealth = 100;
        int rechargeShield = 100;
        string shieldStatus;
        string targetingSystem;

        public CentralComputerCore(string Command, int ComputerPower,string TargetingSystem)
        {
            command = Command;
            computerPower = ComputerPower;
            targetingSystem = TargetingSystem;

        }
        public void Activate()
        {
            TurnShieldOnOrOff();            
        }

        public void Refresh()
        {
            ShieldRecharge(shieldHealth,100);
        }

        public string IssueCommands(string newCommand)
        {
            return newCommand;
        }
        public void UseComputer()
        {
            computerPower--;
        }
        public void TakeCoreDamage()
        {
            coreHealth--;
        }
        public void TakeShieldDamage()
        {
            shieldHealth--;
        }

        public void TurnShieldOnOrOff()
        {
            shieldHealth -= 100;   
            Console.WriteLine("Core shield has been activated!");
            Console.WriteLine("Shield health is at  " + shieldHealth);
                      
        }

        public  int ShieldRecharge(int shieldHealth, int rechargeShield)
        {
            
            Console.WriteLine("Shield is charging.");
            shieldHealth += rechargeShield;
            Console.WriteLine("Shield is now at full charge. " +shieldHealth);
            return shieldHealth;

        }

        public void hasEmail()
        {

            int emailProbMin = 0;
            int emailProbMax = 2;

            Random emailProbability = new Random();
            int eProb = emailProbability.Next(emailProbMin, emailProbMax);

            if (eProb >= 1)
            {
                Console.WriteLine("You have mail!");
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("Scott.wav");
            }
            else
            {
                Console.WriteLine("You have no mail.");

            }
        }

            public void targetEnemy()
        {
            if (command == "target") {
                Console.WriteLine("The Central Computer Core locks on the target coordinates.");
            }
        }

    }
    }


