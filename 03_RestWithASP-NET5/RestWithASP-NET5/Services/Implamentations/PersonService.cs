using RestWithASP_NET5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASP_NET5.Services.Implamentations
{
    public class PersonService : IPersonService
    {
        private List<Person> persons;
        private volatile int count;
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> person = new List<Person>();
            for(int i = 0; i < 8; i++)
            {
                Person per = MockPerson(i);
                persons.Add(per);
            }
            return persons;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                id = IncrementAndGet(),
                FirstName = "Person Name " + i,
                LastName = "Person LastName " + i,
                Address = "Adress " + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person FindByID(long id)
        {
            return new Person
            {
                id = IncrementAndGet(),
                FirstName = "Cinthia",
                LastName =  "Barbosa",
                Address = "Mauá SP",
                Gender = "Male"
            };
        }

        internal void Delete()
        {
            throw new NotImplementedException();
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
