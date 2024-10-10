using System;
namespace Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in Eriks, Hugos och Victors lön här:");
           
            Console.WriteLine("Erik:");
            Double Erik = Double.Parse(Console.ReadLine());
            Console.WriteLine("Hugo:");
            Double Hugo = Double.Parse(Console.ReadLine());
            Console.WriteLine("Victor:");
            Double Victor = Double.Parse(Console.ReadLine());

            Double sum = Erik + Hugo + Victor;
            Double sum1 = sum / 3;

            Console.WriteLine("Medellönen är:" + " " + sum1 + " " + "med Eriks, Hugos och Victors lön");

            Console.ReadKey();
        }
    }
}
