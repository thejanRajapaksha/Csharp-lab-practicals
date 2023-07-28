using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06Q6
{
    internal class array
    {
        public void arraySize(int inputs)
        {
            int i;
            int[] user = new int[inputs];
            for (i = 0; i < inputs; i++)
            {
                Console.Write("Enter number " + i + ":");
                user[i] = int.Parse(Console.ReadLine());
                user[i + 1] = 0;
                if (i < inputs)
                {

                    i++;


                }

            }

            for (i = 0; i < inputs; i++)
            {
                Console.WriteLine(user[i]);
            }
        }

    }
}