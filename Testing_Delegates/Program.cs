using System;

namespace Testing_Delegates
{
    internal class Program
    {
        public delegate void MyDelegate(); // it can has parameter and it can has different return type

        private static void Main(string[] args)
        {
            var customerManager = new CustomerManager();
            HandleException(() =>
            {
                MyDelegate myDelegate = customerManager.SendMessage;
                myDelegate += customerManager.ShowAlert; // when myDelegate() called this method fired like events
                myDelegate -= customerManager.SendMessage; // it cancel the sendMessage event when it called
                myDelegate();
            });
            Func<int, int, int> add = Topla;
            Func<int> getRandomNumber = delegate { return new Random().Next(1, 100); };
            //Func<int> getRandomNumber = () => { return new Random().Next(1, 100); }
            Console.WriteLine(add(2, 3));
            Console.WriteLine(getRandomNumber());
            Console.Read();
        }

        public static int Topla(int x, int y)
        {
            return x + y;
        }

        public static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Alert!");
        }
    }
}