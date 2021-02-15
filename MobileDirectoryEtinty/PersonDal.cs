using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDirectoryEtinty
{
    public class PersonDal
    {
        public List<Person> Get()
        {
            using (PersonDirectoryContext personDirectoryContext=new PersonDirectoryContext())
            {
                return personDirectoryContext.Persons.ToList();
            }
        }

        public void Add(Person person)
        {
            using (PersonDirectoryContext personDirectoryContext = new PersonDirectoryContext())
            {
                personDirectoryContext.Persons.Add(person);
                personDirectoryContext.SaveChanges();
            }
        }
        public void Update(Person person)
        {
            using (PersonDirectoryContext personDirectoryContext = new PersonDirectoryContext())
            {
                var entity = personDirectoryContext.Entry(person);
                entity.State = EntityState.Modified;
                personDirectoryContext.SaveChanges();
            }
        }
        public void Delete(Person person)
        {
            using (PersonDirectoryContext personDirectoryContext = new PersonDirectoryContext())
            {
                var entity = personDirectoryContext.Entry(person);
                entity.State = EntityState.Deleted;
                personDirectoryContext.SaveChanges();
            }
        }
    }
}
