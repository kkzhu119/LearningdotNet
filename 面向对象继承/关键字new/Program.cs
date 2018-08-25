using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 关键字new
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer pr = new Programmer("老张", 21, '男', 3);
            pr.SayHello();
            pr.Test();
            pr.ProgrammerSayHello();
            Console.ReadKey();
        }
    }
    public class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public void SayHello()
        {
            Console.WriteLine("大家好我是人类");
        }
        public void Test()
        {
            Console.WriteLine("这是测试");
        }
        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;

        }
    }
    public class Reporter : Person
    {
        public Reporter(string name, int age, char gender, string hobby)
            : base(name, age, gender)
        {
            this.Hobby = hobby;
        }
        private string _hobby;
        public string Hobby
        {
            get { return _hobby; }
            set { _hobby = value; }
        }
        public new void SayHello()
        {
            Console.WriteLine("大家好我是记者");
        }
        public void ReporterSayHello()
        {
            Console.WriteLine("我叫{0},我是一名狗仔,我的爱好是{1}我是{2}生,我今年{3}岁了", this.Name, this.Hobby, this.Gender, this.Age);
        }
    }
    public class Programmer : Person
    {
        public Programmer(string name, int age, char gender, int workTime)
            : base(name, age, gender)
        {
            this.WorkTime = workTime;
        }
        private int _workTime;
        public int WorkTime
        {
            get { return _workTime; }
            set { _workTime = value; }
        }
        public new void SayHello()
        {
            Console.WriteLine("大家好我是程序员");
        }
        public void ProgrammerSayHello()
        {
            Console.WriteLine("我叫{0},我是一名程序员,我是{1}生,我今年{2}岁了,我的工作年限是{3}年", this.Name, this.Gender, this.Age, this.WorkTime);
        }
    }
}
