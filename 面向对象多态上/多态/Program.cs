﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class Program
    {
        static void Main(string[] args)
        {
            //多态：让一个对象能够表现出多种的状态(类型)
            //Person[] pers = new Person[8];
            Chinese cn1 = new Chinese("韩梅梅");
            Chinese cn2 = new Chinese("李雷");
            Japanese j1 = new Japanese("树下君");
            Japanese j2 = new Japanese("太君");
            Korea k1 = new Korea("金秀贤");
            Korea k2 = new Korea("金贤秀");
            American a1 = new American("科比");
            American a2 = new American("奥尼尔");
            Person[] pers = { cn1, cn2, j1, j2, k1, k2, a1, a2 };
            for (int i = 0; i < pers.Length; i++)
            {
                //实现多态的3种手段:1、虚方法 2、抽象类 3、接口
                pers[i].SayHello();
                //if(pers[i] is Chinese)
                //{
                //    ((Chinese)pers[i]).SayHello();
                //}else if(pers[i] is Japanese)
                //{
                //    ((Japanese)pers[i]).SayHello();
                //}else if(pers[i] is Korea)
                //{
                //    ((Korea)pers[i]).SayHello();
                //}else if(pers[i] is American)
                //{
                //    ((American)pers[i]).SayHello();
                //}

            }
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
        public Person(string name)
        {
            this.Name = name;
        }
        public virtual void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }

    public class Chinese : Person
    {
        public Chinese(string name) 
            : base(name)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("我是中国人，我叫{0}",this.Name);
        }
    }
    public class Japanese : Person
    {
        public Japanese(string name) : base(name)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("我是日本人，我叫{0}",this.Name);
        }
    }
    public class Korea : Person
    {
        public Korea(string name) : base(name)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("我是韩国人，我叫{0}",this.Name);
        }
    }
    public class American : Person
    {
        public American(string name) : base(name)
        {

        }
        public  override void SayHello()
        {
            Console.WriteLine("我是美国人,我叫{0}",this.Name);
        }
    }

}
