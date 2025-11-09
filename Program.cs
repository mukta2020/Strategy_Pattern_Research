using Strategy_Pattern.Fly;
using Strategy_Pattern.Quack;
using System;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor
            = ConsoleColor.Blue;
            Console.WriteLine("==== Mallar Duck Info ====");
            Duck duck = new MallarDuck();
            duck.Display();
            duck.SetFlyBehaviour(new  FlyWithWings());
            duck.SetQuackBehavior(new  Squack());
            duck.PerformFly();
            duck.SetFlyBehaviour(new RocketFly());
            duck.PerformFly();
            duck.PerformQuack();
            duck.Swim();

            Console.ForegroundColor
            = ConsoleColor.Red;
            Console.WriteLine("\n==== Redhead Duck Info ====");
            Duck duck2 = new RedheadDuck();
            duck2.SetFlyBehaviour(new FlyNoWayNew());
            duck2.SetQuackBehavior(new Squack());
            duck2.PerformFly();
            duck2.PerformQuack();
            duck2.Display();

            duck2.Swim();
            Console.ForegroundColor
           = ConsoleColor.DarkYellow;
            Console.WriteLine("\n==== AB Duck Info ====");
            Duck duck3 = new ABDuck();
            duck3.Display();

            duck3.Swim();
            Console.ForegroundColor
           = ConsoleColor.Cyan;
            Console.WriteLine("\n==== AD Duck Info ====");
            Duck duck4 = new ADDuck();
            duck4.Display();

            duck4.Swim();
            Console.ForegroundColor
           = ConsoleColor.Black;
            Console.WriteLine("\n==== AC Duck Info ====");
            Duck duck5 = new ACDuck();
            duck5.Display();
            duck5.Swim();



        }
    }
}
