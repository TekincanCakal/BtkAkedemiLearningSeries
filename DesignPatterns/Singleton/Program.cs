﻿namespace Singleton
{ 
    class Program
    { 
        static void Main(string[] args)
        {

        }
    }

    class CustomerManager
    {
        private static CustomerManager _customerManager; 
        static object _lockObject = new object();
        private CustomerManager()
        {

        }

        public static CustomerManager CreateAsSingleton()
        {
            lock (_lockObject)
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }
            }

            return _customerManager;
        }
    }
}