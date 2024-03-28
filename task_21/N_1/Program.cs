using System;

namespace N_1
{   
    #region Fly
    public interface IFlyBehavior
    {
        public void Fly();
    }

    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    } 

    public class FlyNoWay : IFlyBehavior
    {
        public void Fly() => Console.WriteLine("I can't fly!");  
    }

    public class FlyByRocketPowered : IFlyBehavior
    {
        public void Fly() => Console.WriteLine("I'm flying with a rocket!");
    }
    #endregion

    #region Quack
    public interface IQuackBehavior
    {
        public void Quack();
    }

    public class ClassQuack : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("Quack");
    }

    public class MuteQuack : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("<<Silence>>");
    }

    public class Squeak : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("Squeak");
    }
    #endregion

    #region Ducks
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public Duck(){}

        public abstract void Display();

        public void PerformFly() => flyBehavior.Fly();
        public void PerformQuak() => quackBehavior.Quack();
        public void Swim() => Console.WriteLine("All ducks float, even decoys!");

        public void SetFlyBehavior(IFlyBehavior fb) => this.flyBehavior = fb;
        public void SetQuackBehavior(IQuackBehavior qb) => this.quackBehavior = qb;
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.flyBehavior = new FlyWithWings();
            this.quackBehavior = new ClassQuack();
        }

        public override void Display() => Console.WriteLine("I'm real Mallard duck");
    }

    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            this.flyBehavior = new FlyNoWay();
            this.quackBehavior = new ClassQuack();
        }

        public override void Display() => Console.WriteLine("I'am model duck");
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuak();
            mallard.PerformFly();

            Duck modelDuck = new ModelDuck();
            modelDuck.PerformFly();
            modelDuck.SetFlyBehavior(new FlyByRocketPowered());
            modelDuck.PerformFly();
        }
    }
}
