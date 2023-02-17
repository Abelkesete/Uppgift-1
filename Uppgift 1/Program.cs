using System;
namespace Uppgift_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" skriv två heltal");
            int b = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());
            
            AREA(b, h);
           
        }
        static void AREA(int b, int h)
        {
            Console.WriteLine(b * h);
        }


    }
}