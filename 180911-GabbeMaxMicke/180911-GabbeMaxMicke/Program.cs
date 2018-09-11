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

            Console.WriteLine("Jag har spenderat hela mitt liv i CMD:en.");
            Console.WriteLine("Vart har du spenderat hela ditt liv?");
            string userLife = Console.ReadLine();

            Console.WriteLine("Jaha! Så du har spenderat livet i {0} fan vad tråkigt!", userLife);
            Console.WriteLine("Du har inte funderat på att prova något annat?");
            string userInputProv = Console.ReadLine();




            Console.WriteLine("Vad har du under skon?: ");
            string underSkoInput = Console.ReadLine();
        }
    }
}
