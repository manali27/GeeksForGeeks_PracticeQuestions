/*
 * Problem:
 * Given a string str containing alphanumeric characters, calculate sum of all numbers present in the string.
 *
 * Input:
 * The first line of input contains an integer T denoting the number of test cases. Then T test cases follow.
 * Each test case contains a string containing alphanumeric characters.
 *
 * Example:
 * Input:
 * 4
 * 1abc23           -   Output: 24
 * geeks4geeks      -   Output: 4
 * 1abc2x30yz67     -   Output: 100
 * 123abc           -   Output: 123
 */

using System;
using System.Text.RegularExpressions;

namespace SumOfNumbersInString
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = 0;

            Console.WriteLine("------ SUM OF NUMBERS IN STRING ------\n");
            Console.WriteLine("Enter the number of testcases: ");
            T = Convert.ToInt32(Console.ReadLine());

            while(T-- > 0)
            {
                String str = String.Empty;

                Console.WriteLine("Enter an alphanumeric string: ");
                str = Console.ReadLine();

                string[] numbers = Regex.Split(str, @"\D+");

                int total = 0;

                foreach (string n in numbers)
                {
                    if (!string.IsNullOrEmpty(n))
                    {
                        int i = int.Parse(n);
                        total += i;
                        //Console.WriteLine("Number: {0}", i);
                    }
                }

                Console.WriteLine("Output: " + total);
            }
        }
    }
}
