using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for Addition ");
            Console.WriteLine("Press 2 for Substraction ");
            Console.WriteLine("Press 3 for Multiplication ");
            Console.WriteLine("Press 4 for Divition ");

            Console.WriteLine("Enter your choice: ");
            int no = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            int b = int.Parse(Console.ReadLine());

            Calculator objn = new Calculator();

            if (no == 1)
            {
                int add= objn.Method1(a,b);
                Console.WriteLine("Answer is : "+add);
            }

            else if (no == 2) 
            {
                int sub = objn.Method2(a, b);
                Console.WriteLine("Answer is : " + sub);
            }

            else if(no == 3) 
            {
                int mul = objn.Method3(a, b);
                Console.WriteLine("Answer is : " + mul);
            }
            
            else if( no == 4)
            {
                double div = objn.Method4(a, b);
                Console.WriteLine("Answer is : " + div);
            }

            else
                Console.WriteLine("Entered number is not a valid operation");


            Console.ReadKey();

        }
    }
}
