using StrategyPatternToProgtech.Ducks;
using StrategyPatternToProgtech.Interface;
using System;

namespace StrategyPatternToProgtech
{
    class Program
    {
        static void Main(string[] args)
        {

            Duck mallard = new MallardDuck();
            mallard.perfofmQuack();
            mallard.performFly();

            Duck model = new ModelDuck();
            model.performFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();
        }
    }
}
