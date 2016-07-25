using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthDayCraze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");
            string name = Console.ReadLine();                   //Enter first name

            Console.WriteLine("Enter your month of birth");
            string month = Console.ReadLine().ToLower();         //Enter month that gets converted to lower case version

            Console.WriteLine('\n'+bDay(name,month));            //Writes name + month after passing through method

        }

        //Reverse method
        static string bDay(string j, string k)
        {
            string final = "";

            if(k == "april" || k == "august" || k == "october" )         //check if user entered one of the months
            {
                Console.WriteLine(j + " is an " + k + " baby");
            }
            else if(k == "apr" || k == "aug" || k == "oct")                 //check for abbreviated forms of months
            {
                Console.WriteLine(j + " is an " + k + " baby");
            }
            else
            {
                Console.WriteLine(j + " is a " + k + " baby");
            }
            return final;                                                   //return updated string final
        }
    }
}
