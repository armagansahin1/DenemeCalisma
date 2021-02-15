using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Adress = "ist";

            PersonManager personManager = new PersonManager();
            

            Customer customer2 = new Customer();
            customer2 = customer;
            customer.Adress = "Ankara";
            Employee employee = new Employee();
            employee.Number = 41351;
            personManager.Add(employee);


        }

        class PersonManager
        {
            public void Add(Person person)
            {
                
            }
        }

        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        class Customer:Person
        {
            public string Adress { get; set; }
        }

        class Employee:Person
        {
            public int Number { get; set; }
        }
    }
}
