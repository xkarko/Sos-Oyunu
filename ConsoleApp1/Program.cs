using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 1;
            int s_sayisi = 0;
            int o_sayisi = 0;  
            string[,] sos = new string[10, 10];
            Random random = new Random();
            for (int i = 9; i >= 0; i--)
            {
                for (int j = 9; j >= 0; j--)
                {
                    int deger = random.Next(0, 2);
                    if (deger == 0)
                    {
                        sos[i, j] = "S";
                        s_sayisi++;
                    }
                    if (deger == 1)
                    {
                        sos[i, j] = "O";
                        o_sayisi++;
                    }
                    
                }
                    
            }
            for (int i = 9; i >= 0; i--)
            {
                for (int j = 9; j >= 0; j--)
                {
                    Console.Write(sos[i, j] + "  ");
                    if(sayac % 10 == 0)
                    {
                        Console.Write("\n");
                        Console.Write("\n");
                    }
                    sayac++;
                }
            }
            Console.WriteLine("Bu matristeki -S- harfi tam olarak: " + s_sayisi + " tanedir");
            Console.WriteLine("Bu matristeki -O- harfi tam olarak: " + o_sayisi + " tanedir");
            Console.ReadKey();
           
            




        }
    }
}
