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