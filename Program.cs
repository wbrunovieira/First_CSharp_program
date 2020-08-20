using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what's your name? ");

            string name = Console.ReadLine();

            Console.WriteLine("Hello" + "  " + name);
        }
    }
}
