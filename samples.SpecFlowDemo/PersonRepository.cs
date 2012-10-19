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
