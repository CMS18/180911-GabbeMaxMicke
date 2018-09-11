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
            Console.WriteLine("Trevligt att träffas, " + userName + ", jag är den hemliga mästarkodaren.");
            
            string saga = ""+ userName + " har varit på ICA och handlat smör, pinnar samt ";
            Console.WriteLine("Vad brukar du handla?");
            string extraMatvara = Console.ReadLine();
            saga += extraMatvara;
            saga += ".";
            Console.WriteLine(saga);

            Console.Write("Jag har spenderat hela mitt liv i CMD:en.");
            Console.WriteLine(" Vart har du spenderat hela ditt liv?");
            string userLife = Console.ReadLine();

            Console.Write(userLife + "Hmmm... ");
            Console.WriteLine("Could you be the coder I've been waiting for?");
            Console.WriteLine("HAHA! Nej, tyvärr.");

            Console.WriteLine("Så du har spenderat livet i {0}, fan vad tråkigt!", userLife);
            Console.WriteLine("Du har inte funderat på att prova något annat? I sådant fall, vad?");
            string userInput = Console.ReadLine();
            Console.WriteLine("Fast {0} är ett riktigt kasst yrke. Tänk om!", userInput);
            
            Console.WriteLine("Du förresten, vad har du under skon?: ");
            string underSkoInput = Console.ReadLine();
            Console.WriteLine("" + underSkoInput + "! Shit va Nice Pizza Slize! Låter riktigt gott med {0}", underSkoInput);

            Console.WriteLine("Nej, det där var onödigt.. vaför skriver du ens det här programmet?: ");
            string input = Console.ReadLine();
            Console.WriteLine("Härligt! Att\""+input+"\" låter som en bra idé");
            
            Console.WriteLine("Är det okej om jag berättar min livshistoria?");
            string useless = Console.ReadLine();
            Console.WriteLine("{0}? För längesen i ett modem långt långt bort...",useless);
            Console.WriteLine(".");
            Console.WriteLine("Bodde en kontakt som någon råkat dra ut...");
            Console.WriteLine("Utan värmen från sitt hem så var kontakten tvungen att tänka på sin överlevnad.");
            Console.WriteLine("Kontakten ålade sig fram i jakt efter ett nytt hem. Till hans förskräckelse upptäcker han att... ");
            Console.WriteLine("HAN HAR BOSATT SIG I EN.. JA, I VADÅ?");
            string bosatt = Console.ReadLine();
            Console.WriteLine("VA? KONTAKTEN HAR BOSATT SIG I {0}, USCH!", bosatt);
            
            Console.ReadLine();
        }
    }
}
