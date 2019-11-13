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
            int[,] graph = new int[5,7];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j =  0; j < 7; j++)
                {
                    graph[i, j] = rnd.Next(0,1);
                    graph[0, 0] = 1;
                    graph[0, 5] = 1;
                    graph[0, 6] = 1;
                    graph[1, 0] = 1;
                    graph[1, 1] = 1;
                    graph[2, 1] = 1;
                    graph[2, 5] = 1;
                    graph[2, 4] = 1;
                    graph[2, 2] = 1;
                    graph[3, 2] = 1;
                    graph[3, 3] = 1;
                    graph[4, 4] = 1;
                    graph[4, 3] = 1;
                    graph[4, 6] = 1;
                    Console.Write("{0}\t", graph[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
