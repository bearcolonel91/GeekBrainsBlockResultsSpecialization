using System;

namespace СSharpGeekBrains
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("Введите число элементов массива");
            N = Int32.Parse(Console.ReadLine());

            string[] A = new string[N];

            Console.WriteLine("Введите элементы массива");

            for (int i = 0; i < N; i++)
            {
                A[i] = Console.ReadLine();
            }


            string[] B = new string[N];

            int j = 0;

            for (int i = 0; i < N; i++)
            {
                if (A[i].Length < 4)
                {
                    B[j] = A[i];
                    j++;
                }
            }

            for (int i = 0; i < j; i++)
            {
                Console.Write(B[i]);

                if (i != j - 1)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
