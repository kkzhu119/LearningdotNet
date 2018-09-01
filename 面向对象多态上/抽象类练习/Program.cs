﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用多态求矩形的面积和周长以及圆形的面积和周长
            Shape shape = new Square(4, 5);//new Circle(5);
            double area = shape.GetArea();
            double perimeter = shape.GetPerimeter();
            Console.WriteLine("这个形状的面积是{0:0.00}，周长是{1:0.00}",area,perimeter);
            Console.ReadKey();
        }
    }
    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
    public class Circle : Shape
    {
        private double _r;
        public double R
        {
            get { return _r; }
            set { _r = value; }
        }
        public Circle(double r)
        {
            this.R = r;
        }
        public override double GetArea()
        {
            return Math.PI * this.R * this.R;
        }

        public override double GetPerimeter()
        {
            return 2*Math.PI*this.R;
        }
    }
    public class Square : Shape
    {
        private double _Height;
        public double Height
        {
            get { return _Height; }
            set { _Height = value; }
        }
        private double _Width;
        public double Width
        {
            get { return _Width; }
            set { _Width = value; }
        }
        public Square(double height,double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double GetArea()
        {
            return this.Height * this.Width;
        }

        public override double GetPerimeter()
        {
            return (this.Height + this.Width) * 2;
        }
    }
}
