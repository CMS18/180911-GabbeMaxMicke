using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180911_GabbeMaxMicke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in namn: ");
            string userName = Console.ReadLine();
            string saga = ""+ userName + " har varit på ICA och handlat smör och ";
            string extraMatvara = Console.ReadLine();
            saga += extraMatvara;
            saga += ".";
            Console.WriteLine(saga);

            Console.WriteLine("Trevligt att träffas " + userName + " jag är den hemliga mästarkodaren.");

            Console.WriteLine("Jag har spenderat hela mitt liv i CMD:en.");
            Console.WriteLine("Vart har du spenderat hela ditt liv?");
            string userLife = Console.ReadLine();



        }
    }
}
