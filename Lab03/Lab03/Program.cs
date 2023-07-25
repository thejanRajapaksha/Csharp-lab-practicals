using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
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
        }

        void question1()
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

        void question2()
        {
            Console.WriteLine("Enter a word:");
            string let = Console.ReadLine();
            int vowelCount = 0;
            for (int i = 0; i < let.Length; i++)
            {
                char ch = let[i];

                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                {
                    vowelCount++;
                }
            }
            Console.WriteLine("The number of vowels in this word is {0}.", vowelCount);

            Console.ReadKey();


        }

        void question3()
        {
            Console.WriteLine("Enter a Number:");
            int num = int.Parse(Console.ReadLine());

            int tot = 0;
            while (num > 0)
            {
                int digit = num % 10;
                tot = tot + digit;
                num = num / 10;
            }

            Console.WriteLine("Sum of the Digit = {0}", tot);

            Console.ReadKey();

        }

        void question4()
            {
            Console.WriteLine("Enter a Number:");
            int num = int.Parse(Console.ReadLine());

            int tot = 0;

            while (num > 0)
            {
                int digit = num % 10;

                if (num % 2 == 1)
                {
                    tot += digit;
                }
                num /= 10;
            }

            Console.WriteLine("Sum of the Digit = {0}", tot);

            Console.ReadKey();

        }
    }
}
