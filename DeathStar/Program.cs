using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSecretPlans;
using DeathStar;


namespace DeathStar
{
    public class Program
    {
        static void Main(string[] args)
        {
            DeathStar deathstar = new DeathStar();

            deathstar.CentralCore();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to go into Offensive Mode.");
            Console.ReadKey();
            deathstar.OffenseMode();
            deathstar.Superlaser();

            Console.ReadKey();
        }
    }
}
