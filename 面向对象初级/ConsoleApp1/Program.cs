using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建Person类的对象
            Person Kpc = new Person();
            Kpc.Name = "阚鹏程";
            Kpc.Age = 20;
            Kpc.Gender = '男';
            Kpc.CHLSS();
            Console.ReadKey();
        }
    }
}
