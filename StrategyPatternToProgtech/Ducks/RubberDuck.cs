using StrategyPatternToProgtech.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternToProgtech.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
        }

        public override void display()
        {
            Console.WriteLine("I am a Rubber Duck!!");
        }
    }
}
