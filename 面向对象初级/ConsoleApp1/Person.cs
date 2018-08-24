using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        //字段
        private string _name;
        //属性
        public string Name
        {
            //当输出属性值的时候,执行get方法
            get { return _name; }
            //当给属性赋值的时候,首先用的是set方法
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

        //方法
        public void CHLSS()
        {
            Console.WriteLine("我叫{0},我今年{1}岁了,我是{2}生",this.Name,this.Age,this.Gender);
        }
    }
}
