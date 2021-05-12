namespace Testing_Interfaces
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
        }

    }

    public abstract class IPerson2
    {
        public int Id;
        public string FirstName;
        public string LastName;

        public IPerson2(int id)
        {
            Id = id;

        }

        public void test()
        {

        }
    }
    class Student : IPerson2
    {
        public string Depertmant { get; set; }

        public Student(int id) : base(id)
        {

        }
    }


    interface IPerson
    { 
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

   

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Price { get; set; }
    }
}