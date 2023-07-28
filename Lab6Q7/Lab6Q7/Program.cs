using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 0; int sum2 = 0; int scalar = 0; int sumvp = 0;

            Console.Write("Enter Array size:");
            int arrs = int.Parse(Console.ReadLine());

            int[] array1 = new int[arrs];
            int[] array2 = new int[arrs];
            int[] vsarray = new int[arrs];
            int[] vparray = new int[arrs];

            for (int y = 0; y < arrs; y++)
            {
                Console.Write("Enter 1st array elements:");
                array1[y] = int.Parse(Console.ReadLine());
            }

            for (int y = 0; y < arrs; y++)
            {
                Console.Write("Enter 2nd array elements:");
                array2[y] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrs; i++)
            {
                sum1 = sum1 + array1[i];
            }

            for (int i = 0; i < arrs; i++)
            {
                sum2 = sum2 + array2[i];
            }

            scalar = sum1 + sum2;

            Console.WriteLine("Scalar sum = " + scalar);


            for (int i = 0; i < arrs; i++)
            {
                vsarray[i] = array1[i] + array2[i];
            }

            Console.Write("Vector Sum array:");

            for (int i = 0; i < arrs; i++)
            {
                Console.Write(vsarray[i] + " ");
            }

            Console.WriteLine(" ");

            for (int i = 0; i < arrs; i++)
            {
                vparray[i] = array1[i] * array2[i];
            }

            Console.Write("Vector Product array:");

            for (int i = 0; i < arrs; i++)
            {
                Console.Write(vparray[i] + " ");
            }

            Console.WriteLine(" ");

            for (int i = 0; i < arrs; i++)
            {
                sumvp = sumvp + vparray[i];
            }



            Console.WriteLine("Scalar product: " + sumvp);


            Console.ReadLine();

        }
    }
}