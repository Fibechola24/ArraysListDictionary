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


            /*
            //creating a list to hold objects
            List<Student> studentList = new List<Student>();  //list
            Student student1 = new Student("Victor");
            Student student2 = new Student("Stella");
            studentList.Add(student1);
            studentList.Add(student2);
            Console.WriteLine($"Number in student list is {studentList.Count}");

           Student [] students = { new Student("Fox"), new Student("Jamie") };   //add the array to the list
            studentList.AddRange(students);
            //searching lists 

            Console.WriteLine($" student 2 is at index {studentList.IndexOf(student2)}");

            //access list by index
            if (studentList.Contains(student1))
            {
                //Console.WriteLine($"{student1} is a student");
            }
            */



            //using dictionary
            /*
            Dictionary<int, string> importantYears = new Dictionary<int, string>();
           
            importantYears[1993] = "The year Stella was born";

            Console.WriteLine($"what is the interestiong about the year 1993?");
            Console.WriteLine(importantYears[1993]);
            */

            /*
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("VB","a simple but wordy languange");
            dict.Add("Java", "god but not like c#");
            dict.Add("C#", "the best");

            Console.WriteLine($"Does the dictionary contains C#? {dict.ContainsKey("C#")} ");
            Console.WriteLine();


            //iterating through a dictionary contents 
            Console.WriteLine("Contents of the dictionary");
            foreach ( KeyValuePair<string, string> pair in dict)
            {
                Console.WriteLine($"key: {pair.Key.PadRight(8)} value: {pair.Value}");
            }

            Console.WriteLine("print only the keys and values"); 

            Dictionary<string, string>.KeyCollection keys = dict.Keys;
            foreach (string key in keys)
            {
                Console.WriteLine($"key: {key}");
            }
            Console.WriteLine();
            Dictionary<string, string>.ValueCollection values = dict.Values;
            foreach (var value in values)
            {
                Console.WriteLine($"value: {value}");
            }
            */


            /*task: create a dictionary list of employeee ids and the name that goes with that ID,. fill it with a few records. 
             * ask the user for their id and return their name */

              Dictionary<int, string> employees = new Dictionary<int, string>();
            employees.Add(01, "Johnshon Johnson");
            employees.Add(02, "Stella Seun");
            employees.Add(007, "Emmanuel Afolyan");
            string continueResult;
            do
            {

                Console.Write("please enter your ID number: ");
                string idInput = Console.ReadLine();

                int id = Convert.ToInt32(idInput);

                Console.WriteLine($"The name of the employee is {employees[id]}");
                Console.Write("Do you want to try again? Enter Yes or no");
                continueResult = Console.ReadLine();

            } while (continueResult.ToLower() == "yes");
          




            Console.ReadLine();
        }
    }
}
