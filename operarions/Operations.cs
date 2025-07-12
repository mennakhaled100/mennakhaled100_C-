using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_part1
{
    static class Operations
    {
        //sum
        public static int sum(int[] arr , int size)
        {
            int sum =0 ;
            for( int i=0; i<size; i++)
            {
                sum += arr[i] ;
            }
            return sum ;    
        }
        //max
        public static int max(int[] arr, int size)
        {
            int max = arr[0];
            for (int i = 0; i < size; i++)
            {
                if (arr[i] > arr[0])
                    max = arr[i];
            }
            return max;
        }
        //min
        public static int min(int[] arr, int size)
        {
            int min = arr[0];
            for (int i = 0; i < size; i++)
            {
                if (arr[i] < arr[0])
                    min = arr[i];
            }
            return min;
        }
        //countPositive
        public static int countPositive(int [] arr, int size)
        {
            int countPositive = 0;
            for(int i = 0; i<size; i++)
            {
                if (arr[i] > 0)
                    countPositive++;
            }
            return countPositive;
        }
        //countNegative
        public static int countNegative(int[] arr, int size)
        {
            int countNegative = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                    countNegative++;
            }
            return countNegative;
        }
        //countEven
        public static int countEven(int[] arr, int size)
        {
            int countEven = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 ==0)
                    countEven++;
            }
            return countEven;
        }
        //countOdd
        public static int countOdd(int[] arr, int size)
        {
            int countOdd = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 != 0)
                    countOdd++;
            }
            return countOdd;
        }
        

    }
}
