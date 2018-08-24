using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Student kpcStudent = new Student();
            kpcStudent.Name = "阚鹏程";
            kpcStudent.Age = 18;
            kpcStudent.Gender = '男';
            kpcStudent.Chinese = 100;
            kpcStudent.Math = 100;
            kpcStudent.English = 100;
            kpcStudent.SayHello();
            kpcStudent.ShowScore();
            Student wxStudent = new Student("老李", 14, '男');
            wxStudent.SayHello();


            Student girl = new Student("埃莉丽", 15, '女', 100, 100, 100);
            girl.SayHello();
            girl.ShowScore();
            Console.ReadKey();
       

        }
    }
}
