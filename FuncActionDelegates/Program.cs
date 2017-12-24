using System;

namespace FuncActionDelegates
{
    class Program
    {
        //public static PersonFormat formatPerson;
        private static Func<Person, string> formatPerson;

        static void Main(string[] args)
        {
            var personList = People.GetPeople();

            Console.WriteLine("Please select a method for print. 1, 2, 3 or 4.");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    formatPerson = p => p.ToString();
                    break;
                case "2":
                    formatPerson = p => p.LastName.ToUpper();
                    break;
                case "3":
                    formatPerson = p => p.FirstName.ToLower();
                    break;
                case "4":
                    formatPerson = p => string.Format("{0} {1}", p.FirstName, p.LastName);
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
