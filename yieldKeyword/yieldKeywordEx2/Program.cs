using System;
using System.Collections;
using System.Collections.Generic;

namespace yieldKeywordEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            People peopleList = new People();

            peopleList.AddPerson(new Person { Name = "Onur", SurName = "Kayabasi", Age = 22 });
            peopleList.AddPerson(new Person { Name = "Aleyna", SurName = "Güner", Age = 22 });
            peopleList.AddPerson(new Person { Name = "Erdener", SurName = "Ünal", Age = 22 });

                foreach (Person p in peopleList)
                    Console.WriteLine(p.Name + " " + p.SurName);

            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
    }

    class People : IEnumerable
    {
        private List<Person> people = new List<Person>();

        public void AddPerson(Person person)
        {
            people.Add(person);
        }

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < this.people.Count; i++)
            {
                yield return people[i];
            }
        }
    }
}
