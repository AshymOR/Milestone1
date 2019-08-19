using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogGenetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 100;
            int[] numbers = new int[5];
            string[] breed = new string[] { "Golden Retriever", "Beagle", "Norwegian Elk Hound", "American Pit Bull", "Corgi" };
            Console.WriteLine("What is your dogs name?");
            string name = Console.ReadLine();
            Console.WriteLine("Well then, I have this highly reliable report on " + name + " prestigous background right here.");

            Console.WriteLine(name + " is:");

            for (int i = 0; i < 4; i++)
            {
                Random random = new Random();
                numbers[i] = random.Next(1, total);
                total = total - numbers[i];
            }
            numbers[4] = total;
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine(numbers[j] + "% " + breed[j]);
            }
        }
    }
}
