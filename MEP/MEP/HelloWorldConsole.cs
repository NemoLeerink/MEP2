using System;

namespace HelloWorldConsole
{
    class HelloWorldConsole
    {
        static void Main(string[] args)
        {
            string naam;
            Console.WriteLine("Wat is je naam?");
            naam = Console.ReadLine();
            Console.WriteLine("Hallo, " + naam + "!");
            Console.WriteLine("Je naam heeft " + naam.Length + " letters.");

            // Now is property van DateTime. DateTime is een static class. ToString is een methode die op een DateTime object kan worden uitgevoerd.
            String date = DateTime.Now.ToString("dd/MM/yyy");
            Console.WriteLine(date);

            Console.WriteLine("Wat is je geboortejaar?");
            string geboortejaar = Console.ReadLine();

            int geboortejaarint = int.Parse(geboortejaar);

            int geschatteleeftijd;
            geschatteleeftijd = DateTime.Now.Year - geboortejaarint;

            // Console.WriteLine(DateTime.Now.Year.GetType());
            Console.WriteLine("Geschatte leeftijd is " + geschatteleeftijd);
            Console.ReadKey();
        }
    }
}
