using System;
using System.Collections.Generic;

namespace Testing_ExceptionHandling
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var students = new List<string> {"Ahmet", "Ali", "Mehmet"};
            if (students.Contains("Ahmet"))
                Console.WriteLine("Ahmet found!");
            else
                throw new RecordNotFoundException("Hata Mesajı");

            Console.Read();
        }
    }
}