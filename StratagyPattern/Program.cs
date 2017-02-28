using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratagyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> MyDucks = new List<Duck>();
            MallardDuck first = new MallardDuck();
            RubberDuck second = new RubberDuck();
            CustomDuck third = new CustomDuck(new FlyWithRockets(), new QuackNormal(), new SwimLikeADuck());
            MyDucks.Add(first);
            MyDucks.Add(second);
            MyDucks.Add(third);
            foreach (Duck thisDuck in MyDucks)
            {
                thisDuck.display();
                thisDuck.DoSwim();
                thisDuck.DoQuack();
                thisDuck.DoFly();
            }
            Console.ReadKey();
        }
    }
}
