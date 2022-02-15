using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string [] firstNames = new string[2];
             firstNames[0] = "Victor";
             firstNames[1] = "Oluwaseun";
             Console.WriteLine($"Welcome {firstNames[0]} and {firstNames[1]}");
            */

            string data = "Victor, Fibechola, Okpanachi";
            string[] fullNames = data.Split(',');
            Console.WriteLine($"Your fullname is {fullNames[2]}, {fullNames[1]} {fullNames[0]}");


            Console.ReadLine();
        }
    }
}
