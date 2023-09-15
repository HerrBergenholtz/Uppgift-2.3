using System;

namespace Uppgift_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar vill du hyra denna fina bil?");
            float dagar = float.Parse(Console.ReadLine());
            Console.WriteLine("Hur många kilometer planerar du att köra med bilen?");
            float kilometer = float.Parse(Console.ReadLine());

            float kostnad = (dagar * 500) + kilometer + 300 - 500;
            Console.WriteLine("Det kommer att kosta dig totalt " +  kostnad + "kr att hyra denna bil.");

            Console.ReadKey();
        }
    }
}