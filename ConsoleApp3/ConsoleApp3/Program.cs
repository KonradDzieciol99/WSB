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
                        Console.WriteLine("pole koła to" + Math.PI*promien*promien);
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

            Console.ReadKey();


            



        }
    }
}
