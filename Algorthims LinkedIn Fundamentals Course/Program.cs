using System;

namespace Algorthims_LinkedIn_Fundamentals_Course
{
    class Program
    {
        static int gcd(int a, int b)
        {
            while(b != 0)
            {
                int t = a;
                a = b;
                b = t % b;
            };
            return a;
        }
        static void Main(string[] args)
        {
            int res = gcd(60, 96);
            int res2 = gcd(20, 8);

            Console.WriteLine(res);
            Console.WriteLine(res2);

            /*
             * Common Big-O Terms: 
             * 1- Constant time : O(1) --> Looking up a single element in an array.
             * 2- Logarithmic : O(log n) --> Finding an item in a sorted array with a binary search
             * 3- Linear time : O(n) --> Searching an unsorted array for a specific value
             * 4- Log-Linear : O(n log n) --> Complex sorting algorithms like heap sort and merge sort
             * 5- Quadratic : O(n2) --> Simple Sorting algorithms such as bubble sort, selection sort, and insertion sort
             * 
             * 
             */
        }
    }
}
