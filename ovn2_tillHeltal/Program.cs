using System;

namespace ovn2_tillHeltal
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            // skriver till skärmen
            Console.WriteLine("Skriv ditt första decimaltal");

            // indata från skärmen är alltid i text-format
            // indata måste konverteras innan beräkningar kan göras
            var text1 = Console.ReadLine();
            var tal1 = Convert.ToDouble(text1);

            // avrundning till heltal sker automatiskt
            var heltal1 = Convert.ToInt32(tal1);

            // skriver till skärmen
            Console.WriteLine("Skriv ditt andra decimaltal");

            // indata från skärmen är alltid i text-format
            // indata måste konverteras innan beräkningar kan göras
            var text2 = Console.ReadLine();
            var tal2 = Convert.ToDouble(text2);

            // avrundning till heltal sker automatiskt
            var heltal2 = Convert.ToInt32(tal2);

            // skriver resultatet
            Console.WriteLine("du angav " + tal1 + " och " + tal2);
            Console.WriteLine("avrundat: " + heltal1 + " och " + heltal2);
        }
    }
}
