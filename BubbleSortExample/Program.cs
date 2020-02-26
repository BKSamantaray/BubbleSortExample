using System;

namespace BubbleSortExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 5, 2, 6, 7, 3 };
            for (int i = 1; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length - 1; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        int temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
