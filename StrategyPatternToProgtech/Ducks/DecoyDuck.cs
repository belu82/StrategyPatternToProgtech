using StrategyPatternToProgtech.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternToProgtech.Ducks
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }

        public override void display()
        {
            Console.WriteLine("I am a Decoy Duck!!");
        }
    }
}
