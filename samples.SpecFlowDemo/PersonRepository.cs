using System;
using System.Collections.Generic;

namespace samples.SpecFlowDemo
{
    public static class PersonRepository
    {
        private static readonly Dictionary<int, Person> Persons;

        static PersonRepository()
        {
            Persons = new Dictionary<int, Person>();

            // populate with some data
            var p = new Person { Id = 1, DateOfBirth = new DateTime(1980, 1, 15), Name = "Todd" };
            Persons.Add(p.Id, p);
            p = new Person { Id = 2, DateOfBirth = new DateTime(1975, 6, 30), Name = "Ricky" };
            Persons.Add(p.Id, p);
            p = new Person { Id = 3, DateOfBirth = new DateTime(1985, 12, 1), Name = "Jeff" };
            Persons.Add(p.Id, p);
        }

        public static Person Get(int id)
        {
            if (!Persons.ContainsKey(id))
            {
                return null;
            }
            return Persons[id];
        }

        public static bool Save(Person person)
        {
            if (person == null)
            {
                return false;
            }
            if (!Persons.ContainsKey(person.Id))
            {
                Persons.Add(person.Id, person);
            }
            Persons[person.Id] = person;
            return true;
        }
    }
}
