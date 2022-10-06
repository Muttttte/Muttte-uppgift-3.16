using System;

namespace Uppgift_3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur lång är din låt? ");
            int time = int.Parse(Console.ReadLine());
            int mi = int.Parse(Console.ReadLine());
            int total = int.Parse(Console.ReadLine());
            int t = 260;
            int m = 165;

            if (total <= t && total >= m)
            {
                Console.WriteLine("din låt får vara med !");
            }

            else { Console.WriteLine("tyvär får inte din låt vara med"); }

        }
    }
}