using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket t = new Ticket(90);
            t.ShowTicket();
            Console.ReadKey();
        }
    }
}
