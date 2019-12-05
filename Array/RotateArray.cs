/*
 * Problem:
 * Given an unsorted array arr[] of size N, rotate it by D elements (clockwise).
 *
 * Input:
 * The first line of the input contains T denoting the number of testcases.
 * First line of each test case contains two space separated elements, N denoting the size of the array and an integer D denoting the number size of the rotation.
 * Subsequent line will be the N space separated array elements.
 *
 * Example:
 * Input:
 * 2
 * 5 2
 * 1 2 3 4 5                    -   Output: 3 4 5 1 2
 * 10 3
 * 2 4 6 8 10 12 14 16 18 20    -   Output: 8 10 12 14 16 18 20 2 4 6
 */

using System;
using System.Text;

namespace CodingPractice
{
    public class RotateArray
    {
        static void Main(string[] args)
        {
            int testcases = 0;

            Console.WriteLine("------ Rotate Array ------\n");
            Console.WriteLine("Input: ");
            testcases = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter size of array & number size of rotation separated by space: ");

            while (testcases > 0)
            {
                string input = string.Empty;
                int N = 0; //size of array
                int D = 0; //no. of elements to rotate


                input = Console.ReadLine();
                string[] inputString = input.Split(' ');
                N = Convert.ToInt32(inputString[0]);
                D = Convert.ToInt32(inputString[1]);

                int[] arr = new int[N];

                Console.WriteLine("Enter " + N + " space separated array elements: ");
                string arrInput = Console.ReadLine();
                string[] arrStr = arrInput.Split(' ');

                if (arrStr.Length != N)
                {
                    Console.Error.WriteLine("Size of array should be " + N);
                    Environment.Exit(-1);
                }

                for (int i = 0; i < arrStr.Length; i++)
                {
                    arr[i] = Convert.ToInt32(arrStr[i]);
                }

                StringBuilder sb = new StringBuilder();

                for (int i = D; i < N; i++)
                {
                    sb.Append(arr[i] + " ");
                }

                for (int i = 0; i < D; i++)
                {
                    sb.Append(arr[i] + " ");
                }
                Console.WriteLine("Rotated Array: " + sb);
                testcases--;
            }
        }
    }
}