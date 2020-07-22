using System;

namespace duckApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Duck mallardDuck = new MallardDucK();
            Duck crazyDuck = new CrazyDuck();

            mallardDuck.Display();
            mallardDuck.Quack();
            mallardDuck.Fly();

            crazyDuck.Display();
            crazyDuck.Quack();
            crazyDuck.Fly();

            Console.ReadKey();
        }
    }

   public abstract class Duck
    {
        public void Swim()
        {
            Console.WriteLine("Swim");
        }

        public abstract void Display();

        public void Fly()
        {
            FlyBehaviour.Fly();
        }

        public void Quack()
        {
            QuackBehaviour.Quack();
        }

        protected Duck()
        {
        }

        protected IFlyBehaviour FlyBehaviour;
        protected IQuackBehaviour QuackBehaviour;

    }

   public  interface IFlyBehaviour
   {
       void Fly();
   }

   public interface IQuackBehaviour
   {
       void Quack();
   }

   public class MallardDucK : Duck
   {
        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck");
        }

        public MallardDucK()
       {
            QuackBehaviour = new Squeak();
            FlyBehaviour = new FlyWithWings();
       }

   }

   public class CrazyDuck : Duck
   {
       public override void Display()
       {
           Console.WriteLine("I'm a Crazy Duck");
       }

       public CrazyDuck()
       {
           QuackBehaviour = new Scream();
           FlyBehaviour = new FlyWithPlane();
       }

   }
    public class Squeak : IQuackBehaviour
   {
       public void Quack()
       {
           Console.WriteLine("this is a Squeak");
       }
   }

   public class Scream : IQuackBehaviour
   {
       public void Quack()
       {
           Console.WriteLine("this is a Scream");
       }
   }

    public class FlyWithWings : IFlyBehaviour
   {
       public void Fly()
       {
           Console.WriteLine("this is a Fly with Wings");
       }
   }

    public class FlyWithPlane : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("this is a Fly with Plane");
        }
    }
}
