using System;


namespace First
{

    class Rectangle
    {
        double side1;
        double side2;
        double area;
        double perimeter;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public void PerimeterCalculator()
        {
            perimeter = (side1 * 2) + (side2 * 2);
        }

        public void AreaCalculator()
        {
            area = side1 * side2;
        }

        public double Area
        {
            get
            {
                return area;
            }
        }
        public double Perimeter
        {
            get
            {
                return perimeter;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Rectangle rec = new Rectangle(15, 43);
            rec.AreaCalculator();
            rec.PerimeterCalculator();

            Console.WriteLine("Area = {0}; Perimeter = {1}",  rec.Area, rec.Perimeter);
            Console.ReadKey();
        }
    }
}
