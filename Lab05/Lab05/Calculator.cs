using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    internal class Calculator
    {
        public int Method1(int a, int b)
        {
            int answer = a + b;
            return answer;
        }

        public int Method2(int a, int b)
        {
            int answer = a - b;
            return answer;
        }

        public int Method3(int a, int b)
        {
            int answer = a * b;
            return answer;
        }

        public double Method4(double a, double b)
        {
            double answer = a / b;
            return answer;
        }
    }

}
