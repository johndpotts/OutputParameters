using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace OutputParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, gender;
            GetData(out name, out gender);
            int age = GetAge();
            Console.WriteLine("Name: {0} \n Age: {1} \n Gender: {2}", name, age, gender);
            Console.ReadLine();
            string message = ConfigurationManager.AppSettings["message"];
            Console.WriteLine("The message is: {0}", message);
            Console.ReadLine();
        }
       



        private static int GetAge()
        {
            bool valid = false;
            int number = 0;
            while (!valid)
            {
                Console.WriteLine("Enter your age: ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("That is not an integer!");
                }
            }
            return number;
        }

        private static void GetData(out string name, out string gender)
        {
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your gender");
            gender = Console.ReadLine();
        }
    }
}
