using System;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Good
            int minutesPerHour = 60;

            // OK, but not so easy to understand what m actually is
            int m = 60;
            Console.WriteLine( minutesPerHour + m );
        }
    }
}
