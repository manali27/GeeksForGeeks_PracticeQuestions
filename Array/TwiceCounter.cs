using System;
using System.Linq;
using System.Text;

namespace TwiceCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = 0;

            Console.WriteLine("------ TWICE COUNTER ------\n");
            Console.WriteLine("Enter the number of testcases: ");
            T = Convert.ToInt32(Console.ReadLine());

            while(T-- > 0)
            {
                int N = 0, wordCount = 0, finalCount = 0;
                string[] arrString;

                Console.WriteLine("Enter the size of array: ");
                N = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter " + N + " space separated words: ");
                arrString = Console.ReadLine().Split(' ');
                string[] distinctArr = arrString.Distinct().ToArray();

                
                StringBuilder str = new StringBuilder();

                for (int i = 0; i < distinctArr.Length; i++)
                {
                    str.Append(distinctArr[i] + " ");
                }

                Console.WriteLine(str);

                if (arrString.Length != N)
                {
                    Console.WriteLine("Size of array should be " + N);
                    Environment.Exit(-1);
                }

                for (int i = 0; i < distinctArr.Length; i++)
                {
                    for (int j = 0; j < arrString.Length; j++)
                    {
                        if (distinctArr[i] == arrString[j])
                        {
                            wordCount += 1;
                        }
                    }

                    if (wordCount == 2)
                    {
                        finalCount += 1;
                    }
                    wordCount = 0;
                }

                Console.WriteLine("Output: " + finalCount + "\n");
            }
        }
    }
}
