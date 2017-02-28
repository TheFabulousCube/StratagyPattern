using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratagyPattern
{
    public interface IQuack
    {
        void Quack();
    }

    public class QuackNormal : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Quack, Quack, Quack");
        }
    }
    public class Squeak : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
    public class Silent : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("  . . . . . . . .");
        }
    }

}
