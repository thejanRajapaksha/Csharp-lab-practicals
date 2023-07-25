using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the distance in kilometers: ");
            double kilometers = Convert.ToDouble(Console.ReadLine());

            ConvertValues converter = new ConvertValues();
            double meters = converter.KilometerToMeter(kilometers);

            Console.WriteLine($"{kilometers} kilometers is equal to {meters} meters.");

            Console.ReadKey();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            FindValues circleValues = new FindValues();

            double area = circleValues.FindArea(radius);

            double circumference = circleValues.FindCircumference(radius);

            Console.WriteLine($"Area of the circle: {area:F2}");
            Console.WriteLine($"Circumference of the circle: {circumference:F2}");
        }
    }
}
