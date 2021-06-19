using StrategyPatternToProgtech.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternToProgtech.Ducks
{
    public abstract class Duck
    {
        public QuackBehavior quackBehavior;
        public FlyBehavior flyBehavior;
        
    

        public abstract void display();


        //delegate to the behavior class
        public void performFly()
        {
            flyBehavior.fly();
        }

        public void perfofmQuack()
        {
            quackBehavior.Quack();
        }

        public void swim()
        {
            Console.WriteLine("All duck float, even decoys!");
        }       

        public void setFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void setQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
