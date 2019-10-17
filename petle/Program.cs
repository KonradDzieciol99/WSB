using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             int a=0;
             int y = 0;
             do
             {
                 y = 4 * a;
                 Console.WriteLine(y+"<-y a-> " +a);
                 a++;
             } while (a<16);
            // napisz program powyżej za pomocą petli while

            Console.WriteLine("dfgdfgdfghdfghdfgh " );

            a = 0;
            y = 0;

            while (a < 16)
            {
                y = 4 * a;
                Console.WriteLine(y + "<-y a-> " + a);
                a++;

            }
            // który za pomocą instrukcji while dla danych wartości x zmieniających się w przedziale 
            //od 1 do 50 obliczy ich sumę
           




            int liczba = 0;


            Console.WriteLine("podja liczbę ");
            string Podanaliczba=Console.ReadLine();
            liczba = int.Parse(Podanaliczba);
            
            if(liczba%2==0)
            {
                Console.WriteLine("liczba parzysta");
            }
            else
            {
                Console.WriteLine("nie parzysta");
            }
            

            int liczbaA = 0,liczbaB=0;


            Console.WriteLine("podja liczbę a");
            string Podanaliczba = Console.ReadLine();
            liczbaA = int.Parse(Podanaliczba);

            Console.WriteLine("podja liczbę b");
            Podanaliczba = Console.ReadLine();
            liczbaB = int.Parse(Podanaliczba);

            Console.WriteLine((liczbaA*liczbaB)/(liczbaA+liczbaB));
            

            int liczbaA = 0, liczbaB = 0, liczbaC = 0;


            Console.WriteLine("podja liczbę a");
            string Podanaliczba = Console.ReadLine();
            liczbaA = int.Parse(Podanaliczba);

            Console.WriteLine("podja liczbę b");
            Podanaliczba = Console.ReadLine();
            liczbaB = int.Parse(Podanaliczba);

            Console.WriteLine("podja liczbę c");
            Podanaliczba = Console.ReadLine();
            liczbaC = int.Parse(Podanaliczba);

            int zamiennik = 0;

            if (liczbaB<liczbaA)
            {
                zamiennik = liczbaA;
                liczbaA=liczbaB;
                liczbaB = zamiennik;
            }
            if (liczbaC < liczbaA)
            {
                zamiennik = liczbaA;
                liczbaA = liczbaC;
                liczbaC = zamiennik;
            }
            if (liczbaC < liczbaB)
            {
                zamiennik = liczbaB;
                liczbaB = liczbaC;
                liczbaC = zamiennik;
            }
            

            Console.WriteLine(liczbaA+"<-a"+liczbaB+"<-b"+liczbaC+"<-c");


            while (true)
            {
                
            }
           

            Console.WriteLine("podaj liczbę aby obliczyć z niej silnię");
            int liczbaA = 0;
            int wynik = 1;

            string Podanaliczba = Console.ReadLine();
            liczbaA = int.Parse(Podanaliczba);

            for (int i = 1; i <= liczbaA; i++)
            {
                wynik = wynik * i;
            }
            Console.WriteLine(wynik);
             
            int liczbaA = 0, liczbaB = 0;


            Console.WriteLine("podja szerokość");
            string Podanaliczba = Console.ReadLine();
            liczbaA = int.Parse(Podanaliczba);

            Console.WriteLine("podaj wysokosc");
            Podanaliczba = Console.ReadLine();
            liczbaB = int.Parse(Podanaliczba);


            for (int i = 0; i < liczbaB; i++)
            {

                for (int x = 0; x < liczbaA; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            

            int liczbaA = 0;


            Console.WriteLine("podja wysokosc");
            string Podanaliczba = Console.ReadLine();
            liczbaA = int.Parse(Podanaliczba);

            for (int i = 0; i < liczbaA; i++)
            {
                for (int z = 0; z < (liczbaA-i)-1; z++)
                {
                    Console.Write(" ");

                }

                for (int x = 0; x <= i*2; x++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }
            


            int liczbaA = 0;
            bool czyprawda = false;

            Console.WriteLine("podja liczbe pierwszą");
            string Podanaliczba = Console.ReadLine();
            liczbaA = int.Parse(Podanaliczba);


            for (int i = liczbaA-1; i > 1; i--)
            {
                if (liczbaA%i==0)
                {
                    czyprawda = true;
                }
            }
            if (czyprawda)
            {

                Console.WriteLine("liczba nie jest liczbą pierwsza");


            }else
                Console.WriteLine("liczba jest pierwsza");
            
            //Napisz grę kółko i krzyżyk.

            char[] plansza = new char[9] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
            int liczbaA = 0;
            string Podanaliczba;
            char znak = 'O';

            for (int z=1;true;z++)
            {


                for (int i = 0; i < 9; i++)
                {
                    Console.Write(plansza[i]);

                    if(i==2||i==5||i==8)
                    {
                     


                    }
                    else
                    Console.Write(" | ");


                    if (i == 2 || i == 5)
                    {
                        Console.WriteLine();

                        Console.WriteLine("----------");


                    }
                }

                if (z%2==0)
                {
                    znak = 'O';
                }
                else
                {
                    znak = 'X';
                }

                Console.WriteLine();
                Console.WriteLine("teraz ruch mają " + znak);
                Console.WriteLine("wybierz pole od jeden do 9 na którym postawić pionek");

                Podanaliczba = Console.ReadLine();
                liczbaA = int.Parse(Podanaliczba);
                liczbaA--;
                plansza[liczbaA] = znak;



            }
            */

            int liczbaA = 0, liczbaB = 0 ;

            Console.WriteLine("Szukanie największego wspólnego dzielnika 2 liczb");
            Console.WriteLine("podaj a");   

            string Podanaliczba = Console.ReadLine();
            liczbaA = int.Parse(Podanaliczba);

            Console.WriteLine("podaj b");

            Podanaliczba = Console.ReadLine();
            liczbaB = int.Parse(Podanaliczba);

            for (;true;)
            {



                if (liczbaA % liczbaB == 0)
                {
                    Console.WriteLine("największy wspólny dzielnik to " + liczbaB);
                    break;
                }
                if (liczbaA % liczbaB != 0)
                {
                    int reszta = liczbaA % liczbaB;

                    liczbaA = liczbaB;
                    liczbaB = reszta;
                }

            }
            

            Console.ReadKey();
        }
    }
}
