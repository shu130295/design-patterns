// See https://aka.ms/new-console-template for more information
using StrategyPattern;

Duck mallard = new MallardDuck();
mallard.performQuack();
mallard.performFly();

Console.WriteLine();

Duck model = new ModelDuck();
model.performFly();
model.setFlyBehavior(new FlyRocketPowered());
model.performFly();
