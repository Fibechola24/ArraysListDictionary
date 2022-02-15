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
            

            string data = "Victor, Fibechola, Okpanachi";
            string[] fullNames = data.Split(',');
            Console.WriteLine($"Your fullname is {fullNames[2]}, {fullNames[1]} {fullNames[0]}");
           

            
            string[] names = new string[] { "Sue", "Jone", "Angela" };
            Console.WriteLine(names[2]);
            */


            //create an array of 3 names. ask the user which number to select. when the user gives you a number,, return that name

            string[] names = new string[] { "Vicor", "Angela", "Stella" };
            Console.Write("From 0 to 2 which number do you want to select?\n");
            string numberInput = Console.ReadLine();
            int number = Convert.ToInt32(numberInput);
            Console.WriteLine();
            Console.WriteLine(names[number]);


            Console.ReadLine();
        }
    }
}
