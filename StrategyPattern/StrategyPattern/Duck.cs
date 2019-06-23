using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public abstract class Duck
    {
        private IFlyBehavior _fly;
        private IQuackBehavior _quack;

        public Duck()
        {
        }

        public IFlyBehavior Fly { get { return _fly; } set { _fly = value; } }
        public IQuackBehavior Quack { get { return _quack; } set { _quack = value; } }

        public void PerformFly()
        {
            _fly.Fly();
        }

        public void PerformQuack()
        {
            _quack.Quack();
        }

        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine("\n Every duck can swim \n");
        }
    }
}
