using System;

namespace Day06C_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Struct Employee
            //Employee emp1 = new Employee(1, "HaneenElagamy", 5000);

            //// Display initial details
            //Console.WriteLine("Initial Employee Details:");
            //Console.WriteLine($"Name: {emp1.GetName()}");
            //Console.WriteLine($"Salary: {emp1.Salary}");

            //// Modifying the Name using SetName
            //Console.WriteLine("\nUpdating Name...");
            //emp1.SetName("HaneenAli"); 
            //Console.WriteLine($"Updated Name: {emp1.GetName()}");

            //// Modifying the Salary using the property
            //Console.WriteLine("\nUpdating Salary...");
            //emp1.Salary = 9000; 
            //Console.WriteLine($"Updated Salary: {emp1.Salary}");//10000

            //// Setting a valid Salary
            //emp1.Salary = 15000;
            //Console.WriteLine($"Final Salary: {emp1.Salary}");//15000

            //Constructor overloading
            Point1 pt1 = new Point1(10);
            Console.WriteLine(pt1.ToString());

            Point1 pt2 = new Point1(20,50);
            Console.WriteLine(pt2.ToString());





        }
    }
}
