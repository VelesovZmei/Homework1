using System;

namespace MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int b = 0; b <= 9; b++)
            {
                Console.WriteLine($"{a} x {b} = {a * b}");
            }
        }
    }
}
