﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class OffenseMode
    {
        public void CheckMode()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|-----------------------------|");
            Console.WriteLine("|------Offense Mode........OK-|");
            Console.WriteLine("|-----------------------------|");
            

        }
        public void SystemOk()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|-----------------------------|");
            Console.WriteLine("|------All System........OK!|");
            Console.WriteLine("|-----------------------------|");
           

        }
        public void LaserSound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "peww1.wav";
            player.Load();
            player.Play();
            player.Play();
        }
    }
}
