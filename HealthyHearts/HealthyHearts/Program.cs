using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyHearts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            int max = 220 - age;
            double low = max * .5;
            double high = max * .85;
            low = Math.Round(low);
            high = Math.Round(high);

            Console.WriteLine("Your maximum heart rate should be " + max + " beats per minute");
            Console.WriteLine("Your target HR zone is " + low + " - " + high + " beats per minute");
        }
    }
}
