using System;

namespace StrategyPattern
{
    public interface QuackBehavior
    {
        public void quack();
    }

    public class Quack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }

    public class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }

    public class Squeak : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}