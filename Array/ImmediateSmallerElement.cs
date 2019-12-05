/*
 * Problem:
 * Given an integer array of size N. For each element in the array, check whether the right adjacent element (on the next immediate position) of the array is smaller.
 * If next element is smaller, print that element. If not, then print -1.
 *
 * Input:
 * The first line of input contains an integer T denoting the number of test cases. T testcases follow. Each testcase contains 2 lines of input:
 * The first line contains an integer N, where N is the size of array.
 * The second line contains N integers(elements of the array) sperated with spaces.
 *
 * Example:
 * Input
 * 2
 * 5
 * 4 2 1 5 3        -   Output: 2 1 -1 3 -1
 * 6
 * 5 6 2 3 1 7      -   Output: -1 2 -1 1 -1 -1
 */

using System;
using System.Text;

namespace ImmediateSmallerElement
{
	class Program
	{
		static void Main(string[] args)
		{
			int T = 0;

			Console.WriteLine("------ IMMEDIATE SMALLER ELEMENT ------\n");
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

				for (int i = 0; i < arrString.Length; i++)
				{
					arr[i] = Convert.ToInt32(arrString[i]);
				}

				StringBuilder str = new StringBuilder();

				for (int i = 0; i < arr.Length; i++)
				{
					if (i == arr.Length - 1)
					{
						str.Append("-1 ");
					}
					else
					{
						if (arr[i + 1] < arr[i])
						{
							str.Append(arr[i + 1] + " ");
						}
						else
						{
							str.Append("-1 ");
						}
					}
				}

				Console.WriteLine("Output: " + str + "\n");
			}

		}
	}
}
