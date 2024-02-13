using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialisation_Deserialisation;
namespace Serialisation_dll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\Users\nikhita_palla\Documents\Github\MentorTasks\09-02-2024\Serialisation_OP"; 
            Employee employee1 = new Employee(1,"Ramesh");
            Employee employee2 = new Employee(1, "Ramesh");
            Employee employee3 = new Employee(1, "Ramesh");
            Class1.Serialize<Employee>(directoryPath, employee1);
            Class1.Serialize<Employee>(directoryPath, employee2);
            Class1.Serialize<Employee>(directoryPath, employee3);
            Console.WriteLine("Serialised File created:" + directoryPath);
            Console.WriteLine();

            Employee deserializedemployee = Class1.Deserialize<Employee>(directoryPath);
            Console.WriteLine("Deserialised...");
            Console.WriteLine("Employee ID:" + deserializedemployee.Empid);
            Console.WriteLine("Employee Name:" + deserializedemployee.Name);


        }
    }
}
