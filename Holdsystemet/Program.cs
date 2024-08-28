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

            Hold førstehold = new Hold("Datamatiker", "Roskilde", "A", 2023, true);
            Hold andethold = new Hold("Økonomi", "Næstved", "B", 2023, false);
            Hold tredjehold = new Hold("Musik", "Holbæk", "C", 2023, true);

            Console.WriteLine(førstehold);
            Console.WriteLine(andethold);
            Console.WriteLine(tredjehold);


            Console.WriteLine($"student{førstehold}, {førstestuderende}");
            Console.WriteLine($"Student{andethold}, {andenstuderende}");
            Console.WriteLine($"student{tredjehold},{tredjestuderende}");

           Console.WriteLine("AddStudent");

            Dictionary<int, Studerende> My_dict1 = new Dictionary<int, Studerende>();
            My_dict1.Add(4212, førstestuderende);
            My_dict1.Add(2032, andenstuderende);
            My_dict1.Add(3050, tredjestuderende);

            Console.WriteLine($"AddStudent, {førstestuderende}");



        }
    }
}
