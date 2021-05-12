using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            NLogger asd = new NLogger();
            asd.Log("dx");
            Console.Read();
        }
    }

    public abstract class Logging
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged with Abstract ${message}");
        }
    }

    public class NLogger : Logging
    {
        public NLogger()
        {
            base.Log("test");
        }
       
    }
}
