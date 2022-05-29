using System;

namespace randomArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Array!");

            Console.WriteLine("Введите кол-во строк: ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов");
            int col = int.Parse(Console.ReadLine());

            int[,] array = new int[row, col];
            Random rand = new Random();
            for (int i = 0; i<array.GetLength(0); i++)
            {
                for(int j=0; j<array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(10);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
