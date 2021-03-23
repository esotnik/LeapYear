using System;

namespace LeapYear
{
    class Program
    {
        public static bool IsLeapYear(int y)
        {
            return (y % 400) == 0 || (y % 4) == 0 && (y % 100) != 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsLeapYear(2020));
        }
    }
}
