using System;

namespace ovn5_IF_MedKontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            // hämtar ett svar från skärmen
            Console.WriteLine("Är det fint väder ute?");
            string svar = Console.ReadLine();

            // svaret utvärderas med en switch istället för if-sats
            // innehållet i variabeln 'svar' testas
            switch(svar)
            {
                // fler värden kan testas på samma ställe
                case "J":
                case "j":
                    Console.WriteLine("Gå på picknick!");
                    break;
                case "N":
                case "n":
                    Console.WriteLine("Läs en bok!");
                    break;
                // 'default' är hopsamlingsheat för 'icke träff'
                default:
                    Console.WriteLine("Jag förstår inte vad du menar");
                    break;

            }
        }
    }
}
