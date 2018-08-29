using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建10个对象,通过一个循环,去调用他们各自打招呼的方法
            //Student s = new Student();
            //Person p = new Person();
            Person[] pers = new Person[10];
            Random r = new Random();
            for (int i = 0; i < pers.Length; i++)
            {
                int rNumber = r.Next(1, 7);
                switch (rNumber)
                {
                    case 1:pers[i]=new Student();
                        break;
                    case 2:pers[i] = new Teacher();
                        break;
                    case 3:pers[i] = new ShuaiGe();
                        break;
                    case 4:pers[i] = new MeiNv();
                        break;
                    case 5:pers[i] = new Yeshou();
                        break;
                    case 6:pers[i] = new Person();
                        break;
                }
            }
            for (int i = 0; i < pers.Length; i++)
            {
                if(pers[i] is Student)
                {
                    ((Student)pers[i]).StudentSayHi();
                }else if(pers[i] is Teacher)
                {
                    ((Teacher)pers[i]).TeacherSayHi();
                }else if(pers[i] is ShuaiGe)
                {
                    ((ShuaiGe)pers[i]).ShuaiGeSayHi();
                }else if(pers[i] is MeiNv)
                {
                    ((MeiNv)pers[i]).MeiNvSayHi();
                }else if(pers[i] is Yeshou)
                {
                    ((Yeshou)pers[i]).YeshouSayHi();
                }else{
                    pers[i].PersonSayHi();
                }
            }
            Console.ReadKey();
        }
    }
    public class Person
    {
        public void PersonSayHi()
        {
            Console.WriteLine("我是人类");
        }
    }
    public class Student : Person
    {
        public void StudentSayHi()
        {
            Console.WriteLine("我是学生");
        }
    }
    public class Teacher : Person
    {
        public void TeacherSayHi()
        {
            Console.WriteLine("我是老师");
        }
    }

    public class MeiNv : Person
    {
        public void MeiNvSayHi()
        {
            Console.WriteLine("我是美女");
        }
    }
    public class ShuaiGe:Person
    {
        public void ShuaiGeSayHi()
        {
            Console.WriteLine("我是帅哥");
        }
    }

    public class Yeshou:Person
    {
        public void YeshouSayHi()
        {
            Console.WriteLine("我是野兽");
        }
    }
}
