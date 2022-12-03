using System;

namespace Bidon_Betona
{
    class Program
    {
        static void Main(string[] args)
        {
            //на вход степень на выход коэффициенты
            while (true)
            {
                Console.WriteLine("Введите степень");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] koeff = new int [n+1];
                for (int k = 0; k < koeff.Length; k++)
                {
                    koeff[k] = (factorial(n) / ((factorial(k) * factorial(n - k))));
                }
                for (int i = 0; i < koeff.Length; i++)
                    Console.Write(koeff[i] + " ");
                Console.WriteLine();
                Console.WriteLine("Перейти к Треугольнику? (Y/N)");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    break;
                }
            }
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Введите степень");
                int s = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i <= s; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(treug(i, j) + " ");
                    }
                    Console.WriteLine();

                        
                }
                    

                

            }
        }
        static int factorial (int x)
        {
            if (x == 0)
                return 1;
            while (x>=0)
                return (x * factorial(x - 1));
            return 0;
        }
        static int treug (int x, int y)
        {
            if (y == 0 || y == x)
                return 1;
            else
                return treug(x - 1, y - 1) + treug(x - 1, y);
        }

    }
}
