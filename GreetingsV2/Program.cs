using System;

namespace GreetingsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsub kasutaja käest nime
            //programm küsib kasutaja perekonnanime
            //programm tervitab kasutajat, kasutades neid andmeid

            Console.WriteLine("Mis on teie eesnimi?");

            String First = Console.ReadLine();

            Console.WriteLine("Mis on teie perekonnanimi");

            String Last = Console.ReadLine();

            Console.WriteLine($"Hello, {First} {Last}");

            Console.Read();
        }
    }
}
