using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerableAndIEnumerator
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
            return new MyEnumerator(people);
        }
    }

    class MyEnumerator : IEnumerator
    {
        private List<Person> _peopleForIteration = new List<Person>();

        int position = -1;

        public MyEnumerator(List<Person> peopleForIteration)
        {
            _peopleForIteration = peopleForIteration;
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public Person Current
        {
            get
            {
                try
                {
                    return _peopleForIteration[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            Console.Write(position.ToString() + ". indexli nesne => ");

            return (position < _peopleForIteration.Count);
        }

        public void Reset() => position = -1;
    }
}
