using System.Runtime.CompilerServices;

namespace Lekce1bverze;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //Car car = new Car();
        //car.SetColor("blue");

        int rectangleArea = Rectangle.Calculate(2, 4);
    
    }
    class Car
    {
        private string color;

        public Car(string color)
        {
            this.color = "white";
        }

        public void SetColor(string color)
        {
            this.color = color;
        }
    }

    // we want a method that calculates an area of rectangle without an instance of class rectangle
    class Rectangle
    {
        public static int Calculate(int a, int b)
        {
            return a * b;
        } 
    }
}
