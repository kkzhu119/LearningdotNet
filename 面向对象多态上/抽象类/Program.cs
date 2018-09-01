using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            //狗狗会叫，猫咪也会叫
            Animal a = new Cat();//new Dog();
            a.Bark();
            Console.ReadKey();
        }
    }
    public abstract class Animal
    {
        public abstract void Bark();  
    }
    public class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("汪汪叫");
        }
    }
    public class Cat : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("喵喵喵");
        }
    }

}
