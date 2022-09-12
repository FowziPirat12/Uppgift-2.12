using System;
namespace Uppgift_2._12
{
    class Progrma
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar ska du hyra bilen?");
            string dagar = Console.ReadLine();
            Console.WriteLine("Hur många kilometer ska du köra");
            String distans = Console.ReadLine();

            float dagar_tal1 = float.Parse(dagar);
            float distans_tal1 = float.Parse(distans);

            float resa = 300 + distans_tal1 + (dagar_tal1 * 500) - 500;

            Console.WriteLine("Bilen kommer att kosta dig" + resa); 
        }
    }
}