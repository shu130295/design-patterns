using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public abstract class Duck
    {
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;

        public Duck() { }

        public abstract void display();

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
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
