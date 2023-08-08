using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine($"Sum: {numbers.Sum()}\n");


            //TODO: Print the Average of numbers
            Console.WriteLine($"Average: {numbers.Average()}\n");


            //TODO: Order numbers in ascending order and print to the console
            var ascNum = numbers.OrderBy(x => x);
            Console.Write("Ascending: ");
            foreach (var num in ascNum)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");

            //TODO: Order numbers in descending order and print to the console
            var descNum = numbers.OrderByDescending(x => x);
            Console.Write("Descending: ");
            foreach (var num in descNum)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");

            //TODO: Print to the console only the numbers greater than 6
            var greatThan6 = numbers.Where(x => x > 6);
            Console.Write("Greater than six: ");
            foreach (var num in greatThan6)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var only4 = numbers.OrderBy(x => x).Take(4);
            Console.Write("Only four of 'em: ");
            foreach (var num in only4)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[4] = 24;
            var ageChange = numbers.OrderByDescending(x => x);
            Console.Write("Age at index 4 to my age, descending: ");
            foreach (var num in ageChange)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if
            //      their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var firstNameCorS = employees.Where(x => x.FirstName.ToLower().StartsWith("c") || x.FirstName.ToLower().StartsWith("s"));
            var firstNameCorSAsc = firstNameCorS.OrderBy(x => x.FirstName);
            Console.WriteLine("Ascending C or S first names: ");
            foreach (var person in firstNameCorSAsc)
            {
                Console.WriteLine($"{person.FullName} ");
            }
            Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console
            //      and order this by Age first and then by FirstName in the same result.
            var over26 = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);
            Console.WriteLine("Over 26 by age then first name: ");
            foreach (var person in over26)
            {
                Console.WriteLine($"{person.FullName} {person.Age}");
            }
            Console.WriteLine();

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience
            //      if their YOE is less than or equal to 10 AND Age is greater than 35.
            var olderAmateurs = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            var sumOlderAmateurs = olderAmateurs.Sum(x => x.YearsOfExperience);
            Console.WriteLine($"Sum of experience for older amateurs: {sumOlderAmateurs}");
            Console.WriteLine();
            var avgOlderAmateurs = olderAmateurs.Average(x => x.YearsOfExperience);
            Console.WriteLine($"Average years of experience for older amateurs: {avgOlderAmateurs}\n");

            //TODO: Add an employee to the end of the list without using employees.Add()
            var updatedEmp = employees.Append(new Employee("Mack", "McCall", 24, 1));
            Console.WriteLine("List of employees after the new guy:");
            foreach (var person in updatedEmp)
            {
                Console.WriteLine($"Name: {person.FullName} | Age: {person.Age} | Years of Experience: {person.YearsOfExperience}");
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
