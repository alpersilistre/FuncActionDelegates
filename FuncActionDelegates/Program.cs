using System;

namespace FuncActionDelegates
{
    class Program
    {
        public static PersonFormat formatPerson;

        static void Main(string[] args)
        {
            var personList = People.GetPeople();

            Console.WriteLine("Please select a method for print. 1, 2, 3 or 4.");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    formatPerson = Formatters.Default;
                    break;
                case "2":
                    formatPerson = Formatters.LastNameToUpper;
                    break;
                case "3":
                    formatPerson = Formatters.FirstNameToUpper;
                    break;
                case "4":
                    formatPerson = Formatters.FullName;
                    break;
            }
                                                 
            foreach (var p in personList)
            {                 
                Console.WriteLine(p.ToString(formatPerson));
            }

            Console.ReadLine();
        }
    }
}
