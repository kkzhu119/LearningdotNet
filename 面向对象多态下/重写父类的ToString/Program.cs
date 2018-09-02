using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 重写父类的ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine(p.ToString());
            //p.ToString();
            Console.ReadKey();
        }
    }
    public class Person
    {
        //ToString是object的虚方法
        public override string ToString()
        {
            return "Hello World";
        }
    }
}
