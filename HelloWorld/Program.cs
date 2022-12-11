using System;

namespace HelloWorld
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            Console.WriteLine(GreetFriends("Sameer"));

        }

        public static string GreetFriends(string friend)
        {
            return String.Format("Hello {0} my Friend!", friend);
        }
    }
}
