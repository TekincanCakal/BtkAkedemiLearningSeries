using System;
using System.Linq;
using System.Reflection;

namespace Testing_Reflection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3); aynı şey
            var dortIslem = (DortIslem) Activator.CreateInstance(typeof(DortIslem), 2, 3);

            var instance = Activator.CreateInstance(typeof(DortIslem), 2, 3);
            Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null));
            var methods = typeof(DortIslem).GetMethods();
            foreach (var method in methods)
            {
                Console.Write("Method Adı: {0}", method.Name);
                if (method.GetParameters().Length > 0)
                {
                    Console.Write(" Parameters: ");
                    foreach (var parameter in method.GetParameters())
                    {
                        Console.Write("{0} ", parameter.Name);
                    }
                }
                if (method.GetCustomAttributes().ToList().Count > 0)
                {
                    Console.Write("Attributes: ");
                    foreach (var attribute in method.GetCustomAttributes())
                    {
                        Console.Write("{0} ", attribute.GetType().Name);
                    }
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }

    public class DortIslem
    {
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int _sayi1, _sayi2;

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }
}