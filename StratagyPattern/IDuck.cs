using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratagyPattern
{
    public abstract class Duck
    {
        public IFly flyAction;
        public IQuack quackAction;
        public ISwim swimAction;

        public Duck()
        {

        }

        public void DoQuack()
        {
            quackAction.Quack();
        }
        public void DoFly()
        {
            flyAction.Fly();
        }
        public void DoSwim()
        {
            swimAction.Swim();
        }
        public abstract void display();
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyAction = new FlyWithWings();
            quackAction = new QuackNormal();
            swimAction = new SwimLikeADuck();
        }

        public override void display()
        {
            Console.WriteLine("I'm a real Mallard Duck");
        }
    }
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyAction = new CantFly();
            quackAction = new Squeak();
            swimAction = new Float();
        }

        public override void display()
        {
            Console.WriteLine("Rubber Duckie, You're the one!");
        }
    }
    public class CustomDuck : Duck
    {
        public CustomDuck(IFly _fly, IQuack _quack, ISwim _swim)
        {
            flyAction = _fly;
            quackAction = _quack;
            swimAction = _swim;
        }
        public override void display()
        {
            Console.WriteLine("I'm a custom duck, my actions can be decided when I'm created!");
        }
    }

}
