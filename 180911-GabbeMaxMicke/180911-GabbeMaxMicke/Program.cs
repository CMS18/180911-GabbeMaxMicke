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
            Console.WriteLine("Trevligt att träffas " + userName + " jag är den hemliga mästarkodaren.");
           

            string saga = ""+ userName + " har varit på ICA och handlat smör och pinnar";

            Console.WriteLine("Vad brukar du handla?");
            string extraMatvara = Console.ReadLine();
            saga += extraMatvara;
            saga += ".";

            Console.WriteLine(saga);

            

            Console.WriteLine("Jag har spenderat hela mitt liv i CMD:en.");
            Console.WriteLine("Vart har du spenderat hela ditt liv?");
            string userLife = Console.ReadLine();

            Console.WriteLine(userLife + " hmmm...");
            Console.WriteLine("Could you be the coder I've been waiting for?");
            Console.WriteLine("Nej, tyvärr.");

            Console.WriteLine("Jaha! Så du har spenderat livet i {0}, fan vad tråkigt!", userLife);
            Console.WriteLine("Du har inte funderat på att prova något annat? I sådant fall, vad?");
            string userInputProv = Console.ReadLine();
            Console.WriteLine("Fast {0} är ett riktigt kasst yrke. Tänk om!", userInputProv);
            
            Console.WriteLine("Vad har du under skon?: ");
            string underSkoInput = Console.ReadLine();
            Console.WriteLine("" + underSkoInput + "! Shit va Nice Pizza Slize!");
        }
    }
}
