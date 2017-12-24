using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FuncActionDelegates
{
    public static class People
    {
        public static List<Person> GetPeople()
        {
            var p = new List<Person>()
            {
                new Person(){ FirstName = "John", LastName = "Koenig", StartDate = new DateTime(1975, 10, 15), Rating = 6 },
                new Person(){ FirstName = "Dylan", LastName = "Hunt", StartDate = new DateTime(1965, 11, 14), Rating = 7 },
                new Person(){ FirstName = "Dave", LastName = "Lister", StartDate = new DateTime(1985, 12, 13), Rating = 9 },
                new Person(){ FirstName = "Rick", LastName = "Sheridan", StartDate = new DateTime(1977, 06, 27), Rating = 6 },
                new Person(){ FirstName = "Isaac", LastName = "Montana", StartDate = new DateTime(1976, 07, 23), Rating = 4 }
            };

            return p;
        }
    }

    //public delegate string PersonFormat(Person input);

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public int Rating { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
        
        public string ToString(Func<Person, string> format)
        {
            if (format != null)
                return format(this);
            
            return this.ToString();
        }
    }
}
