using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path类
{
    class Program
    {
        static void Main(string[] args)
        {
            //Path//静态类
            string str = @"c:\2000\1212\s\c\v\dd\你牛逼.wav";
            Console.WriteLine(Path.GetFileName(str));
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));
            Console.WriteLine(Path.GetExtension(str));
            Console.WriteLine(Path.GetDirectoryName(str));
            Console.WriteLine(Path.GetFullPath(str));
            Console.WriteLine(Path.Combine(@"c:\a\"+"b.txt"));
            
            Console.ReadKey();
        }
    }
}
