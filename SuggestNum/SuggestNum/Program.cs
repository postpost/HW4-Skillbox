using System;

namespace SuggestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давай поиграем!");
            int maxValue = 0;
            do
            {
                Console.WriteLine("Введите число диапазона");
                int n = int.Parse(Console.ReadLine());
                Random rand = new Random();
                maxValue = rand.Next(0, n + 1);
                Console.WriteLine("Чтобы завершить игру, введи пустую строку или нажми Enter для продолжения");
                if (Console.ReadLine() == " ") break;
                do
                {
                    Console.WriteLine("Введите целое число");
                    int input = int.Parse(Console.ReadLine());
                    if (maxValue > input) Console.WriteLine("Загаданное число больше");
                    else if (maxValue < input) Console.WriteLine("Загаданное число меньше");
                    else if (maxValue == input) {Console.WriteLine($"Вы выиграли! Загаданное число = {maxValue}"); break; }
                } while (true);
                
            } while (true);
            Console.WriteLine($"Загаданное число было = {maxValue}");
        } 
    }
}
