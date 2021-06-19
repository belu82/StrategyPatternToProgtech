using StrategyPatternToProgtech.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternToProgtech.Quack
{
    class DuckQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
