﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{

    public class OverBridge
    {
        int numberOfStairwells;
        int numberOfDutyPosts;
        int numberOfControlConsole;
        bool holoDisplayPad;




         OverBridge(int numberOfStairwells, int numberOfDutyPosts, int numberOfControlConsole, bool holoDisplayPad)
        {
            this.numberOfDutyPosts = numberOfDutyPosts;
            this.numberOfStairwells = numberOfStairwells;
            this.numberOfControlConsole = numberOfControlConsole;
            this.holoDisplayPad = holoDisplayPad;
        }
         void turnOnDisplayPad()
        {
            this.holoDisplayPad = true;
        }
         void checkSystems()
        {
            Console.WriteLine("All systems good");
        }
    }





}
