using System;

namespace Największa_liczba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę x");
            Console.WriteLine("Podaj liczbę y");
            Console.WriteLine("Podaj liczbę z");

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            int ax = int.Parse(x);
            int ay = int.Parse(y);
            int az = int.Parse(z);

            if (ax > ay && ax  > az) { Console.WriteLine(ax + "jest największa z podanych"); }
            else if (ay > ax && ay > az) { Console.WriteLine(ay + "jest największa z podanych"); }
            else if (az > ax && az > ay) { Console.WriteLine(az + "jest największa z podanych"); }




        }
    }
}
