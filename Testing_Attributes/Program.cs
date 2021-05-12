using System;

namespace Testing_Attributes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var customerDal = new CustomerDal();
            var customer = new Customer
            {
                Id = 1,
                Age = 18,
                FirstName = "Mehmet"
            };
            customerDal.Add(customer);
            Console.Read();
        }
    }

    [ToTable("Customer")]
    internal class Customer
    {
        public int Id { get; set; }

        [RequiredProperty] public string FirstName { get; set; }

        [RequiredProperty] public string LastName { get; set; }

        [RequiredProperty] public int Age { get; set; }
    }

    internal class CustomerDal
    {
        [Obsolete("Don't use this Add, this is old you can use new add")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3}", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    internal class RequiredPropertyAttribute : Attribute
    {
    }

    internal class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}