using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratagyPattern
{
    public interface IFly
    {
        void Fly();
    }
    public class FlyWithWings : IFly
    {
        public FlyWithWings()
        {
            Console.WriteLine("This Duck can fly!");
        }

        public void Fly()
        {
            Console.WriteLine("I'm Flying!");
        }
    }

    public class CantFly : IFly
    {
        public CantFly()
        {
            Console.WriteLine("This Duck can NOT fly!");
        }

        public void Fly()
        {
            Console.WriteLine("I'm NOT Flying!");
        }
    }

    public class FlyWithRockets : IFly
    {
        public FlyWithRockets()
        {
            Console.WriteLine("This Duck is flying with rockets!");
        }

        public void Fly()
        {
            Console.WriteLine("I'm Soaring!");
        }
    }
}
