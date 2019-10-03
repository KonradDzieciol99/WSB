using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dlugosc");
            string a = Console.ReadLine();



            Console.WriteLine("szerokos");
            int bb = int.Parse(Console.ReadLine());

            int aa = int.Parse(a);


            Console.WriteLine("pole prostokąta to  {0} ",aa*bb);

            Console.ReadKey();

        }
    }
}
