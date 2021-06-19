using StrategyPatternToProgtech.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternToProgtech
{
    class FlyWithWings : FlyBehavior
    {
        //flying behavior implementation for ducks that can fly

        public void fly()
        {
            Console.WriteLine("I'm flying");

        }
    }
}
