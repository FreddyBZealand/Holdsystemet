using System.Security.Cryptography.X509Certificates;

namespace Holdsystemet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Studerende førstestuderende = new Studerende(4212, "Anders", "Købehavnsvej 12 Roskilde", "4080122436");
            Studerende andenstuderende = new Studerende(2032, "Mette", "Ringstedgade 40 Roskilde", "2911872410");
            Studerende tredjestuderende = new Studerende(3050, "Jørgen", "Solsortevej 2 Roskilde", "2042016910");

            førstestuderende.Name = "Anders";
            andenstuderende._name = "Mette";
            tredjestuderende._name = "Jørgen";
            Console.WriteLine(førstestuderende);
            Console.WriteLine(andenstuderende);
            Console.WriteLine(tredjestuderende);
        }
    }
}
