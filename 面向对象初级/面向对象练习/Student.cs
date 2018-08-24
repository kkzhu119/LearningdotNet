using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象练习
{
    public class Student
    {
        //构造函数
        public Student(string name,int age,char gender,int chinese,int math,int english)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Chinese = chinese;
            this.Math = math;
            this.English = english;
        }
        public Student() { }
        public Student(string name, int age, char gender):this(name,age,gender,0,0,0)
        {}
        public Student(string name):this(name,0,'0',0,0,0)
        {}

        ~Student()
        {
            Console.WriteLine("我是析构函数");
        }
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
            set {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value; }
        }
        private char _gender;
        public char Gender
        {
            get {
                if (_gender != '男' && _gender != '女')
                {
                    return _gender = '男';
                }

                return _gender; }
            set { _gender = value; }
        }
        private int _chinese;
        public int Chinese
        {
            get { return _chinese; }
            set { _chinese = value; }
        }
        private int _math;
        public int Math
        {
            get { return _math; }
            set { _math = value; }
        }
        private int _english;
        public int English
        {
            get { return _english; }
            set { _english = value; }
        }
        public void SayHello()
        {
            Console.WriteLine("我叫{0}我今年{1}岁了,我是{2}生", this.Name, this.Age, this.Gender);
        }
        public void ShowScore()
        {
            Console.WriteLine("我叫{0},我的总成绩是{1},平均成绩是{2}",this.Name,this.Chinese+this.Math+this.English,(this.Chinese+this.Math+this.English)/3);
        }
    }
}
