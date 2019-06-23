using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duckFrank = new OldDuck();
            duckFrank.Display();
            duckFrank.PerformFly();
            duckFrank.PerformQuack();

            duckFrank.Fly = new FlyNot();
            duckFrank.PerformFly();

            Console.ReadKey();
        }
    }
}
