using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            a.question1();
            a.question2();
            a.question3();
            a.question4();
            a.question5();
        }

        void question1()
        {
            Console.WriteLine("Enter first number : ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            int b = int.Parse(Console.ReadLine());

            int sum = a + b;
            Console.WriteLine("Summation is " + sum);

            Console.ReadKey();

        }

        void question2()
        {
            Console.WriteLine("Enter first number : ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            double b = double.Parse(Console.ReadLine());

            double sum = a + b;
            Console.WriteLine("Summation is : " + sum);

            double sub = a - b;
            Console.WriteLine("Substraction is : " + sub);

            double mul = a * b;
            Console.WriteLine("Multiplication is : " + mul);

            double div = a / b;
            Console.WriteLine("Division is : " + div);

            Console.ReadKey();

        }

        void question3()
        {
            Console.WriteLine("Enter the radius : ");
            double r = double.Parse(Console.ReadLine());

            double C = (2 * 22 * r) / 7;
            double A = (22 * r * r) / 7;

            Console.WriteLine("Circumferance is " + C);
            Console.WriteLine("Area is " + A);

            Console.ReadKey();

        }

        void question4()
        {
            Console.WriteLine("Enter a number : ");
            double a = double.Parse(Console.ReadLine());

            double no = a % 2;
            if (no == 0)
            {
                Console.WriteLine(a + " is a an even number");
            }
            else
            {
                Console.WriteLine(a + " is an odd number");
            }

            Console.ReadKey();

        }

        void question5()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number : ");
                double a = double.Parse(Console.ReadLine());

                double no = a % 2;
                if (no == 0)
                {
                    Console.WriteLine(a + " is a an even number");
                }
                else
                {
                    Console.WriteLine(a + " is an odd number");
                }
            }

            Console.ReadKey();

        }
    }
}
