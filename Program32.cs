using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] graph = new int[8, 8];                                                                                      
            int[] arr = new int[7];
            int j;
            for (int i = 1; i<8; i++)
            {
                for (j = 1; j<8; j++)
                {
                    graph[i, j] = 0;
                    graph[1, 2] = 1;
                    graph[1, 3] = 1;
                    graph[1, 7] = 1;
                    graph[2, 1] = 1;
                    graph[2, 3] = 1;
                    graph[2, 4] = 1;
                    graph[3, 1] = 1;
                    graph[3, 2] = 1;
                    graph[4, 5] = 1;
                    graph[4, 2] = 1;
                    graph[5, 6] = 1;
                    graph[5, 4] = 1;
                    graph[6, 7] = 1;
                    graph[6, 5] = 1;
                    graph[7, 6] = 1;
                    graph[7, 1] = 1;
                    Console.Write("{0}\t", graph[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < 7; i++)
            {
                arr[i] = 0;
            }
            arr[0] = 1;
            int k = 1;
            for (int i =1; i< 8; i++)
            {
                for ( j = 1; j < 8;j++)
                {
                    if (graph[i, j] == 1)
                    {
                        bool flag = true;
                        for (int x = 0; x < 7; x++)
                        {
                            if (arr[x] == j)
                                flag = false;

                        }

                        if (flag == true && k < 7)
                        {
                            arr[k] = j;
                            k = k + 1;

                        }
                    }
                }
            }
            for (int i = 0; i<7;i++)
            {
                Console.Write(arr[i]);
            }


            Console.ReadKey();
            
            


        }
    }
}
