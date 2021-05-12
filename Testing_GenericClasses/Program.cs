using System;
using System.Collections.Generic;

namespace Testing_GenericClasses
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var utilieties = new Utilieties();
            var result = utilieties.BuildList("word1", "word2", "word3");
            foreach (var x in result) Console.WriteLine(x);

            Console.Read();
        }
    }

    internal class Utilieties
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    internal interface ITest
    {
    }

    internal class Customer : ITest, ICustomerDal
    {
        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Custom()
        {
            throw new NotImplementedException();
        }
    }

    internal interface ICustomerDal : IRepository<Customer>
    {
        void Custom();
    }

    internal interface IRepository<T>
        where T : class, ITest, new() //T referance tip olmalı ve new lenebilir olmalı demek için where kullanıldı ve new herzaman en sona yazılır ve T artık ITest den implemente olmalı, class yerine struct yazsaydım T sadece değer tipler olabilir int32 gibi
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}