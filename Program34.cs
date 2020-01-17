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
            int p;
            int pl;
            Console.WriteLine("Введите 2 числа");
            p = Convert.ToInt32(Console.ReadLine());
            pl = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Сумма вводимых чисел " + Sp(p, pl));
            Console.WriteLine(Sp1(ref p, ref pl));
            Console.WriteLine(p +" "+ pl);
            ///Console.WriteLine(ref );
            /// Console.WriteLine("Без параметра" + Sp(p, pl, pi));
            Console.ReadKey();
        }
        static int Sp(int p,int pl )
        {
            
            int Sum = p + pl ;
            return p + pl ;
        }
        static int Sp1(ref int p, ref int pl)
        {

            p++;
            pl++;
            int Sum = p + pl;
            return p + pl;
            
        }
    }
}
