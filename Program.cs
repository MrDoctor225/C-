using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            bool z = true;
            int[,] graph = new int [6, 6];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    graph[i, j] = rnd.Next(1,1);
                    Console.Write("{0}\t", graph[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            while (z)
            {
                
                Console.Write("Введите координату строки!  ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите координату ряда!  ");
                y = Convert.ToInt32(Console.ReadLine());
                graph[x, y] = 0;
                if (x==9 && y==9)
                {
                    z = false;
                }
            }
            Console.WriteLine();
            Console.Write("{0}\t", graph[x, y]);
            Console.ReadKey();
        }
    }
}
