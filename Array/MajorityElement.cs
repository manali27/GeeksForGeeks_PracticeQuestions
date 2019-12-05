/*
 * Problem:
 * Given an array A of N elements. Find the majority element in the array.
 * A majority element in an array A of size N is an element that appears more than N/2 times in the array.
 *
 * Input:
 * The first line of the input contains T denoting the number of testcases.
 * The first line of the test case will be the size of array and second line will be the elements of the array.
 *
 * Example:
 * Input:
 * 2
 * 5
 * 3 1 3 3 2    -   Output: 3
 * 3
 * 1 2 3        -   Output: -1
 *
 */

using System;

namespace MajorityElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = 0;
            Console.WriteLine("------ MAJORITY ELEMENT IN ARRAY ------\n");
            Console.WriteLine("Enter the number of testcases: ");
            T = Convert.ToInt32(Console.ReadLine());

            while (T-- > 0)
            {
                int N = 0;
                string[] arrString;

                Console.WriteLine("Enter the size of array: ");
                N = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter " + N + " space separated array elements: ");
                arrString = Console.ReadLine().Split(' ');

                if (arrString.Length != N)
                {
                    Console.Error.WriteLine("Size of array should be " + N);
                    Environment.Exit(-1);
                }

                int[] arr = new int[N];
                int maxCount = 0, index = -1;

                for (int i = 0; i < arrString.Length; i++)
                {
                    arr[i] = Convert.ToInt32(arrString[i]);
                }

                for (int i = 0; i < N; i++)
                {
                    int count = 0;
                    for(int j = 0; j < N; j++)
                    {
                        if(arr[i] == arr[j])
                        {
                            count++;   
                        }

                        if(count > maxCount)
                        {
                            maxCount = count;
                            index = i;
                        }
                    }
                }

                if(maxCount > N / 2)
                {
                    Console.WriteLine("Majority Element: " + arr[index]);
                }
                else
                {
                    Console.WriteLine("Majority Element: " + -1);
                }
            }
        }
    }
}
