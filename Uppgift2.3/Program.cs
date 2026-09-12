using System;
namespace Uppgift2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur mycket tjänar Elvin per månad?");
            string input = Console.ReadLine();
            Console.WriteLine("Hur mycket tjänar Dion per månad?");
            string input2 = Console.ReadLine();
            Console.WriteLine("Hur mycket tjänar Mohammed per månad?");
            string input3 = Console.ReadLine();
            Console.WriteLine((Convert.ToInt32(input) + Convert.ToInt32(input2) + Convert.ToInt32(input3)) / 3);
            Console.WriteLine("Medelinkomsten per månad är: " + (Convert.ToInt32(input) + Convert.ToInt32(input2) + Convert.ToInt32(input3)) / 3);
        }
    }
}