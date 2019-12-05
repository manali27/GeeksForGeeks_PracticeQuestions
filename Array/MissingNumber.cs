/*
 * Problem:
 * Given an array C of size N-1 and given that there are numbers from 1 to N with one element missing, the missing number is to be found.
 *
 * Input:
 * The first line of input contains an integer T denoting the number of test cases.
 * For each test case first line contains N(size of array). The subsequent line contains N-1 array elements.
 *
 * Example:
 * Input:
 * 2
 * 5
 * 1 2 3 5                  -   Output: 4
 * 10
 * 1 2 3 4 5 6 7 8 10       -   Output: 9
 */

using System;

namespace MissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = 0;
            Console.WriteLine("------ MISSING NUMBER IN ARRAY ------\n");
            Console.WriteLine("Enter the number of testcases: ");
            T = Convert.ToInt32(Console.ReadLine());

            while(T-- > 0)
            {
                int N = 0;
                string[] arrString;

                Console.WriteLine("Enter the size of array: ");
                N = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter 1 to " + (N - 1) + " space separated array elements: ");
                arrString = Console.ReadLine().Split(' ');

                if(arrString.Length != (N - 1))
                {
                    Console.Error.WriteLine("Size of array should be " + (N-1));
                    Environment.Exit(-1);
                }

                int[] arr = new int[N];
                int prev = 0, diff= 0;

                for (int i = 0; i < arrString.Length; i++)
                {
                    arr[i] = Convert.ToInt32(arrString[i]);
                     
                    diff = arr[i] - prev;
                    if(diff == 2)
                    {
                        Console.WriteLine("Output: " + (prev + 1));
                    }
                    prev = arr[i];
                }
            }
        }
    }
}
