using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerKdagdag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef je geboortedatum op als dd-mm-yyyy");
            string geboortedatum = Console.ReadLine();

            DateTime birthDate = DateTime.ParseExact(geboortedatum, "dd-MM-yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);

            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthDate.Year;

            if (birthDate.Date > currentDate.AddYears(-age)) age--;


            TimeSpan ts = currentDate.Date.Subtract(birthDate);

            // verKdagdag is bij 1024 dagen een kroon-verKdagdag bij 8192 dagen
            int nextVerKdagdag = 1024 - (ts.Days % 1024);
            int nextKroonVerKdagdag = 8192 - (ts.Days % 8192);

            string ook = "";

            if (nextKroonVerKdagdag == nextVerKdagdag) ook = "ook ";

            Console.WriteLine("Je leeftijd in jaren is {0}.\nJe leeftijd in dagen is {1}.", age, ts.Days);
            Console.WriteLine("Je eerst volgende verKdagdag is over {0} dagen.", nextVerKdagdag);
            Console.WriteLine("Je eerst volgende kroon-verKdagdag is {0}over {1} dagen.", ook, nextKroonVerKdagdag);
            Console.ReadKey();
        }
    }
}
