using System;
namespace Uppgift_2._1 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vilken favorit bok har du ?");
            string bok = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("hens favorit bok är " + bok);
            Console.ReadKey();
        }
    }
}