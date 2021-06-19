using StrategyPatternToProgtech.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternToProgtech.Quack
{
    class MuteQuack : QuackBehavior

    {
        public void Quack()
        {
            Console.WriteLine("Silence");
        }
    }
}
