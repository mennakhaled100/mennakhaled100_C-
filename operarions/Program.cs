using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter arr size");
           int size = int.Parse( Console.ReadLine());
            Console.WriteLine("Enter arr values");
            int[] arr = new int[size];
            for(int i=0; i<size; i++)
            {
                arr[i] =    int .Parse(Console.ReadLine());
            }

            int sum = Operations.sum(arr , size);
            int min = Operations.min(arr , size);
            int max = Operations.max(arr, size);
            int positive = Operations.countPositive(arr, size);
            int negative = Operations.countNegative(arr, size);
            int even = Operations.countEven(arr, size);
            int odd = Operations.countOdd(arr, size);

            Console.WriteLine("operations on arr: ");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Positive: " + positive);
            Console.WriteLine("Negative: " + negative);
            Console.WriteLine("Even: " + even);
            Console.WriteLine("Odd: " + odd);
        }
    }
}
