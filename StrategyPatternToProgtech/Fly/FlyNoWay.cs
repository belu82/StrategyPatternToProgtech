using StrategyPatternToProgtech.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternToProgtech
{
    class FlyNoWay : FlyBehavior
    {
        //flying behavior implementation for ducks that do not fly
        public void fly()
        {
            Console.WriteLine("I can't fly"); 
        }
    }
}
