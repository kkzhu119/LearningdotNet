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
            //Student s = new Student();
            //子类可以赋值给父类
            Person p = new Student();//s;
            //如果父类中装的是子类对象,那么可以将这个父类强转为子类对象
            Student ss = (Student)p;
            //Teacher t = (Teacher)p;  //无法转换
            //t.TeacherSayHello();
            ss.StudentSayHello();
            //if (p is Teacher)
            //{
            //    Teacher t = (Teacher)p;
            //    t.TeacherSayHello();
            //}
            //else
            //{
            //    Console.WriteLine("转换失败");
            //}

            //as用法
            Teacher t = p as Teacher;
            Student m = p as Student;
            
            Console.ReadKey();
        }
    }
    public class Person
    {
        public void PersonSayHello()
        {
            Console.WriteLine("我是父类");
        }
    }
    public class Student : Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生");
        }
    }
    public class Teacher : Person
    {
        public void TeacherSayHello()
        {
            Console.WriteLine("我是老师");
        }
    }
}
