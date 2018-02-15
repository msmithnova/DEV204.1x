using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Self
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] result = GetStudentInformation();
            string firstName = result[0];
            string lastName = result[1];
            string birthday = result[2];
            try
            {
                ValidateBirthday(birthday);
            }
            catch
            {
                Console.WriteLine("ValidateBirthday not implemented yet. Next call may crash.");
            }
            PrintStudentDetails(firstName, lastName, birthday);
        }

        static string[] GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter birthdate (yyyy, mm, dd): ");
            string date = Console.ReadLine();
            return new string[] { firstName, lastName, date };
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
            string[] dateSplit = birthday.Split(',');
            DateTime birthdate = new DateTime(Int32.Parse(dateSplit[0]), Int32.Parse(dateSplit[1]), Int32.Parse(dateSplit[2]));
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthdate.ToLongDateString());

        }

        static bool ValidateBirthday(string birthday)
        {
            // Not developed yet.
            throw new NotImplementedException();
        }
    }
}
