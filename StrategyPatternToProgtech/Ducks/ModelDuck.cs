using StrategyPatternToProgtech.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternToProgtech.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new DuckQuack();
        }
        public override void display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
