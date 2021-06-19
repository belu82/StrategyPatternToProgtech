using StrategyPatternToProgtech.Interface;
using StrategyPatternToProgtech.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternToProgtech.Ducks
{
    public class MallardDuck:Duck
    {
        public MallardDuck()
        {
            quackBehavior = new DuckQuack();
            flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            throw new NotImplementedException();
        }
    }
}
