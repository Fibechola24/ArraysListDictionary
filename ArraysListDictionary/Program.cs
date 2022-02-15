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


            /*
            //create an array of 3 names. ask the user which number to select. when the user gives you a number,, return that name

            string[] names = new string[] { "Vicor", "Angela", "Stella" };
            Console.Write("From 0 to 2 which number do you want to select?\n");
            string numberInput = Console.ReadLine();
            int number = Convert.ToInt32(numberInput);
            Console.WriteLine();
            Console.WriteLine(names[number]);
            */

            /*

            //LISTS
            List<string> names = new List<string>();

            names.Add("Tim");
            names.Add("Sue");
            Console.WriteLine($"Your name is {names[0]} {names[1]}");
            */


            /*
            //add students to a class rooster until there are no more students. Then print out the count of the students

            //plan
            //create a list for the rooster

            List<string> rooster = new List<string>();

            //add students to the list
            string reply;
            do
            {
                Console.Write("Enter names of students: ");
                string name = Console.ReadLine();
                rooster.Add(name);
                Console.Write("Do you want to add another name to a rooster? Yes or no: ");
                reply = Console.ReadLine();
                

            } while (reply.ToLower() == "yes");

            Console.WriteLine($" The total number of students = {rooster.Count}");
            */



            Console.ReadLine();
        }
    }
}
