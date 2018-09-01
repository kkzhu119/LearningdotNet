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
            RealDuck rd = new RealDuck();
            WoodDuck wd = new WoodDuck();
            XpDuck xp = new XpDuck();
            RealDuck[] ducks = { rd, wd, xp };
            for (int i = 0; i < ducks.Length; i++)
            {
                ducks[i].Bark();
            }
            Console.ReadKey();

        }
    }
    public class RealDuck
    {
        public virtual void Bark()
        {
            Console.WriteLine("嘎嘎");
        }
    }
    public class WoodDuck:RealDuck
    {
        public override void Bark()
        {
            Console.WriteLine("吱吱");
        }
    }

    public class XpDuck:RealDuck
    {
        public override void Bark()
        {
            Console.WriteLine("唧唧");
        }
    }
}
