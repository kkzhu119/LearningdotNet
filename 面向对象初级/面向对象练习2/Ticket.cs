using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象练习2
{
    //写一个Ticket类 有一个距离属性(本属性只读,在构造函数中赋值)
    //不能为负数,有一个价格属性,价格属性只读,并且根据距离distance计算价格Price(1元/公里)
    public class Ticket
    {
        private double _distance;
        public double Distance
        {
            get { return _distance; }
        }
        public Ticket(double distance)
        {
            if (distance < 0)
            {
                distance = 0;
            }
            this._distance = distance;
        }
        private double _price;
        public double Price
        {
            get {
                if (_distance > 0 && _distance <= 100)
                {
                    return _distance * 1.0;
                }else if (_distance >= 101 && _distance < 200)
                {
                    return _distance * 0.95;
                }else if (_distance >= 201 && _distance < 300)
                {
                    return _distance * 0.9;
                }
                else
                {
                    return _distance * 0.8;
                }
            }
        }
        public void ShowTicket()
        {
            Console.WriteLine("{0}公里需要{1}元",this.Distance,this.Price);
        }
    }
}
