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

            string[] words = new string[N];

            Console.WriteLine("Введите элементы массива");

            from (int i = 0, i < N, i++)
            {
                words[i] = ReadLine();
            }



        }
    }
}