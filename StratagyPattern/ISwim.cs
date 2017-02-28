using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratagyPattern
{
    public interface ISwim
    {
        void Swim();
    }
    public class SwimLikeADuck : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("I'm swimming like a duck!");
        }
    }
    public class Float : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("I can't swim, I just float");
        }
    }
}
