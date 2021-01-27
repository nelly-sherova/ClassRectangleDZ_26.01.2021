using System;

namespace RectangleClass
{
    class Rectangle 
    {
        private double slide1;
        private double slide2;
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Вас приветствует класс Rectangle!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Slide1 = "); double.TryParse(Console.ReadLine(), out double s1);
            Console.Write("Slide2 = "); double.TryParse(Console.ReadLine(), out double s2);
            Rectangle rec1 = new Rectangle(s1, s2);
            rec1.AreaCalculator();
            rec1.PerimeterCalculator();
            Console.WriteLine($"Площадь вашего треуголника: {rec1.Area}");
            Console.WriteLine($"Периметр вашего прямоугольника: {rec1.Perimeter}");


        }
    }
}
