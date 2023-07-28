using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of inputs: ");
            int inputs = int.Parse(Console.ReadLine());

            array ui = new array();

            ui.arraySize(inputs);

            Console.ReadLine();
        }
    }
}