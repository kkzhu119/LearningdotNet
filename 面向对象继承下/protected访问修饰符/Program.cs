using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protected访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
            //public private  protected
        }
    }
    public class Person
    {
        protected string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
    public class Student : Person
    {
        public void Test()
        {
            //_name;
        }
    }


}
