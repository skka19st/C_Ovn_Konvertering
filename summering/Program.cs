using System;

namespace summering
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            // skriver till skärmen
            Console.WriteLine("Skriv ditt första tal");

            // indata från skärmen är alltid i text-format
            // indata måste konverteras innan beräkningar kan göras
            var text1 = Console.ReadLine();
            int tal1 = Convert.ToInt32(text1);

            // skriver till skärmen
            Console.WriteLine("Skriv ditt andra tal");

            // indata från skärmen är alltid i text-format
            // indata måste konverteras innan beräkningar kan göras
            var text2 = Console.ReadLine();
            int tal2 = Convert.ToInt32(text2);

            // summera de båda talen
            int summa = tal1 + tal2;

            // skriver välkomsthälsning
            Console.WriteLine("du angav " + tal1 + " och " + tal2);
            Console.WriteLine("tillsammans blir det " + summa);
        }
    }
}
