using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            Console.WriteLine("1 pole kwadratu");
            Console.WriteLine("2 pole koła");


            string x = Console.ReadLine();
            int b = int.Parse(x);


            switch (b)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("pole kwadratu");
                    Console.WriteLine("podaj bok a");
             
                    string q = Console.ReadLine();
                    int bok;

                    if(int.TryParse(q, out bok))
                    {
                        Console.WriteLine("pole to"+bok * bok);
                    }
                    else
                    {
                        Console.WriteLine("złe dane!!!");
                    }



                    break;
                case 2:
                    Console.WriteLine("pole kola");

                    Console.Clear();
                    Console.WriteLine("podaj promien r");

                    string k = Console.ReadLine();
                    double promien;

                    if (double.TryParse(k, out promien))
                    {
                        Console.WriteLine("pole koła to" +Math.Round(Math.PI*promien*promien, 3));
                    }
                    else
                    {
                        Console.WriteLine("złe dane!!!");
                    }



                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("!!!");
                    break;
            }
            
            
    
            while (true)
            {

                Console.WriteLine()

                int[,] oceny = new int[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        Console.Write(oceny[i, z] + " ");
                    }
                    Console.WriteLine("");
                }

            }  
            

            Console.WriteLine("asdfas");
            for (int i = 20; i >= 5; i--)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);

                }
            }
            */
            Console.WriteLine("wysokość choinki");
            
            string x;
            x = Console.ReadLine();
            int podajgwiazdki = int.Parse(x);
            
            //int.TryParse(x,out podajgwiazdki);
            for (int i=1; i <= podajgwiazdki ; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }





            Console.ReadKey();


            



        }
    }
}
