using System;

namespace VS_Пр_01_Бедняков__Шевелев
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("GenerateTableUmnaz");
            Console.WriteLine("------------------");

            Console.Write("   |");
            for (int i = 1; i <=10; i++)
            {
                Console.Write($"{i,4}");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 40));
            
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i,3} |");
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j,4}");
                }
                Console.WriteLine();
            }
        }
    }
}
