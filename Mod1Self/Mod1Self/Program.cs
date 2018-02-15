using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1Self
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student Information
            string studentFirstName = "John";
            string studentLastName = "Doe";
            DateTime studentBirthdate = new DateTime(1991, 5, 14);
            string studentAddressLine1 = "123 Main Street";
            string studentAddressLine2 = "";
            string studentCity = "Anytown";
            string studentStateProvince = "Nova Scotia";
            string studentZipPostal = "B9Z 6C7";
            string studentCountry = "Canada";

            //Teacher Information
            string teacherFirstName = "Edsger";
            string teacherLastName = "Dijkstra";
            DateTime teacherBirthdate = new DateTime(1971, 7, 24);
            string teacherAddressLine1 = "345 King Street";
            string teacherAddressLine2 = "";
            string teacherCity = "Ourtown";
            string teacherStateProvince = "Nova Scotia";
            string teacherZipPostal = "B9Z 4C1";
            string teacherCountry = "Canada";

            // UProgram Information
            string programName = "Computer Science Essentials";
            string departmentHead = "Alan Turing";
            string degrees = "All of them";

            // Degree Information
            string degreeName = "BSc Computer Science";
            int creditsRequired = 25;

            // Course Information
            string courseName = "Introducion to C#";
            double credits = 0.5;
            int durationInWeeks = 4;
            string teacher = $"{teacherFirstName} {teacherLastName}";

            Console.WriteLine($"Student {studentFirstName} {studentLastName} is from {studentCity}, {studentStateProvince}, {studentCountry}.");
            Console.WriteLine($"Teacher {teacherFirstName} {teacherLastName} is from {teacherCity}, {teacherStateProvince}, {teacherCountry}.");
            Console.WriteLine($"Program Name: {programName}, Department Head: {departmentHead}");
            Console.WriteLine($"Degree Name: {degreeName}, Credits Required: {creditsRequired}");
            Console.WriteLine($"Course Name: {courseName}, Credits: {credits}, Duration (in weeks): {durationInWeeks}");
        }
    }
}
