using StrategyPatternToProgtech.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternToProgtech.Ducks
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new DuckQuack();
        }


        public override void display()
        {
            Console.WriteLine("I'm a Redhead Duck!!");
        }
    }
}
