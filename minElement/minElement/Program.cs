using System;

namespace minElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min value in sequence!");
            Console.WriteLine("Введите длину массива");
            int n = int.Parse(Console.ReadLine());
            int[] sequence = new int[n];

            for (int i = 0; i<sequence.Length; i++)
            {
                Console.WriteLine("Введите целое число для массива");
                sequence[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Получившийся массив");
            
            foreach (var e in sequence)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();

            int minValue = sequence[0];

            for (int i = 0; i < sequence.Length; i++)
            {
               minValue = (minValue < sequence[i]) ? minValue : sequence[i];
            }
            Console.WriteLine($"минимальное число в массиве = {minValue}");
        }
    }
}
