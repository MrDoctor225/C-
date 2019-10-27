using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Файл
{
    class Program
    {
        static void Main(string[] args)
        {
            /*        1 int[,] file = new int[10, 10];
              int sum = 0;
              int[] mass = new int[10];
              Random ran = new Random();
              for (int i = 0; i < 10; i++)
              {
                  for (int j = 0; j < 10; j++)
                  {
                      file[i, j] = ran.Next(1,12);
                      Console.Write("{0}\t", file[i,j]);
                  }
              }
              for (int i = 0; i < 10; i++)
              {
                  sum =0;
                  for (int j = 0; j < 10; j++)
                  {
                      sum = sum + file[i, j];

                  }
                  mass[i] = sum;
                  Console.WriteLine(mass[i]);

              }
             int maxmass = 0;
             for (int i = 0; i < 10; i++)
              {
                 if(mass[i]> maxmass) { maxmass = mass[i]; }

              }
              Console.WriteLine();
              Console.WriteLine(maxmass);
              Console.ReadKey();
             
                        2int[,] file = new int[4, 5];
            Random ran = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    file[i, j] = ran.Next(1, 9);
                    Console.Write("{0}\t", file[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0}\t", Math.Pow(file[i, j], 2));
                }
            Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0}\t", (file[i, j]*(-1)));
                }
            Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
            
                  3   int[,] scl = new int[7, 3];
            int[] mass = new int[7];
            int cnt = 0;
            Random ran = new Random();
            for (int i = 0; i < 7; i++)
            {
                mass[i] = 0;
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    scl[i, j] = ran.Next(1, 6);
                    Console.Write("{0}\t", scl[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 7; i++)
            {
                
                for (int j = 0; j < 3; j++)
                {
                    if (scl[i,j] == 5)
                    {
                        mass[i]++;
                    }                   
                }
                Console.Write("{0}\t", mass[i]);
                Console.WriteLine();
            }
            Console.WriteLine();
            cnt = 0;
            for (int i = 0; i < 7; i++)
            {
                if (mass[i] == 0)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
            Console.WriteLine();
            Console.ReadKey();
            
            4  int[,] gr = new int[7, 4];
            int[] success = new int[7];
            double cnt = 0;
            int avg = 0;
            Random rnd = new Random();
            for (int i = 0; i < 7; i++)
            {
                success[i] = 0;
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    gr[i, j] = rnd.Next(2, 5);
                    Console.Write("{0}\t", gr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (gr[i, j] == 2)
                    {
                        success[i]++;
                    } 
                }
                Console.Write("{0}\t", success[i]);
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 7; i++)
            {
                if (success[i] > 0)
                {
                    cnt++;
                }
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j =0; j < 4; j++)
                {
                    cnt = cnt + gr[i, j];
                }
            }
            Console.WriteLine(cnt);
            cnt = cnt / 28;
            Console.WriteLine(cnt);
            Console.WriteLine();
            Console.ReadKey();
            
            5 int[,] mass = new int[4, 5];
            int[] resp = new int[4];
            int k = -1;
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                resp[i] = 0;
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mass[i, j] = rnd.Next(1, 4);
                    Console.Write("{0}\t", mass[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                k = -1;
                for (int j = 0; j < 4; j++)
                {
                    for (int g = j + 1; g < 3; g++)
                    {
                        if (mass[i, j] == mass[i, g])
                        {
                            k = i;
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine(k);
                Console.ReadKey();
            }
            */
            6 int[,] field = new int[5,5];
            Random rnd = new Random ();
            int x = 0;
            int y = 0;
            int cnt = 0;
            bool z = true;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    field[i, j] = rnd.Next(0, 2);
                    Console.Write("{0}\t", field[i,j]);
                    if
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            while (z)
            {
                Console.Write("Ввежите координату строки");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите координату ряда");
                y = Convert.ToInt32(Console.ReadLine());
                if(field[x,y] == 1 )
                {
                    z = false;
                    Console.Write("Вы проиграли!");
                }
            }
            
            Console.ReadKey();
        }
    }
}
