using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口的特点
{
    class Program
    {
        static void Main(string[] args)
        {
            //IFlyable fly = new IFlyable();   抽象类 接口 静态类不可以被实例化
            IFlyable fly = new Person();
            fly.Fly();
            IFlyable flyBird = new Bird();
            flyBird.Fly();
            Console.ReadKey();
        }

    }
    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("小鸟在飞");
        }
    }

    public class Person:IFlyable
    {
        public void Fly() { Console.WriteLine("人类在飞"); }
    }

    public interface IFlyable
    {
        //不允许有访问修饰符
        //方法 属性 索引器
        void Fly();
    }
}
