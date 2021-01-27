using System;

namespace RectangleClass
{
    class Rectangle 
    {
        public double slide1;
        public double slide2;
        public Rectangle(){}
        public Rectangle(double slide1, double slide2)
        {
            this.slide1 = slide1;
            this.slide2 = slide2;
        }
        public double AreaCalculator()
        {
            return slide2 * slide1;
        }
        public double PerimeterCalculator()
        {
            return 2 * (slide1 + slide2);
        }
        public double Area {get{return AreaCalculator();}}
        public double Perimeter{get{return PerimeterCalculator();}}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
        }
    }
}
