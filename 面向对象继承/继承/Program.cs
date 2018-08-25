using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("李大钊",18,'男',101);


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
        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        //public Person() { }
        public void CHLSS()
        {
            Console.WriteLine("吃喝拉撒睡");
        }
    }
    public class Student : Person
    {

        public Student(string name, int age, char gender, int id) 
            : base(name, age, gender)
        {
            this.ID = id;
        }
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public void learn()
        {
            Console.WriteLine("学习");

        }
    }
    public class Teacher : Person
    {

        public Teacher(string name,int age,char gender,double salary)
            :base(name,age,gender)
        {
            this.Salary = salary;
        }
        private double _salary;
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public void teacher()
        {
            Console.WriteLine("教书");
        }
    }
    public class Driver : Person
    {
        public Driver(string name,int age,char gender,int driverTime)
            :base(name,age,gender)
        {
            this.DriveTime = driverTime;
        }
        private int _driveTime;
        public int DriveTime
        {
            get { return _driveTime; }
            set { _driveTime = value; }
        }

        public void drive()
        {
            Console.WriteLine("开车");
        }
    }
}
