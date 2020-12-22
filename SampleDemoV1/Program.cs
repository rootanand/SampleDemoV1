using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemoV1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public int Sum(int i, int j)
        {
            return i + j;
        }

        public int Product(int i, int j)
        {
            return i * j;
        }
        //this is my contribution and it does not interfere with the product method
        public double Divide(int numerator, int denominator)
        {
            return (double)numerator / denominator;
        }


    }
}
