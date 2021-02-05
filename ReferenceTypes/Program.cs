using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Person person1 = new Person();
            //Person person2 = new Person();
            //person1.FirstName = "Engin";

            //person2 = person1;
            //person1.FirstName ="Derin";

            //Console.WriteLine(  person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "1234567890";

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer;
            customer.FirstName = "Ahmet";


            //Console.WriteLine(((Customer)person3).CreditCardNumber); 

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);

        }
    }
            //Console.WriteLine(person3.FirstName);

            //base class:Person

    

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

     class Customer : Person
     {
        public string CreditCardNumber { get; set; }
     }

     class Employee :Person
     {    
        public int EmployeeNumber { get; set; }
     }
    class PersonManager
    {
        public void Add(Person person)
        {
             Console.WriteLine(person.FirstName);  
        }
    } 
}


