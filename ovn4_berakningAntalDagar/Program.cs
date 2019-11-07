using System;

namespace ovn4_berakningAntalDagar
{
    class Program
    {
        static void Main(string[] args)
        {
            // hämtar in namn och skriver hälsning
            Console.WriteLine("Hej, vad heter du?");
            var namn = Console.ReadLine();

            // '$' och '{}' är specialtecken för att kunna lägga 
            // in variabler mitt i texten
            Console.WriteLine($"Välkommen hit, {namn}!");
            
            // hämta ålder och beräkna antal dagar
            Console.WriteLine("Hur gammal är du?");
            string ageYear = Console.ReadLine();
            int ageDays = Convert.ToInt32(ageYear) * 365;

            Console.Write($"{ageYear} år! ");
            Console.WriteLine($"Då har du levt i {ageDays} dagar.");
        }
    }
}
