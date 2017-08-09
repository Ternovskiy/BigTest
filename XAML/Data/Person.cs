using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAML.Data
{
    class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public static Person[] GetPersons()
        {
            var result = new Person[]
            {
                new Person() {FirstName = "Иванов", LastName = "ивава"},
                new Person() {FirstName = "ввв", LastName = "вввв"},
                new Person() {FirstName = "ыыыы", LastName = "ыыыы"},
            };
            return result;

        }
    }
}
