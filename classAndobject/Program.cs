using System;

namespace ClassAndObject
{
    public class Testing
    {
        public void Checking()
        {
           Console.WriteLine("Hello, Sabina Karki.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Testing Check123 = new Testing();
            Check123.Checking();
        }
    }
}
