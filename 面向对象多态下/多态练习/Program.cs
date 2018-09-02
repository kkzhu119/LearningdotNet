using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //真的鸭子会游泳，木头鸭子不会游泳 橡皮鸭子会游泳
            ISwimming swim = new RealDuck();
            swim.Swim();
            Console.ReadKey();
        }
    }

    public class RealDuck : ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("真的鸭子靠脚丫子游泳");
        }
    }

    public class MuDuck
    {
        
    }
    public class XPDuck : ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("橡皮鸭子瞎几把游");
        }
    }
    public interface ISwimming
    {
        void Swim();
    }
}
