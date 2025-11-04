using System;

namespace Assignment
{
    class log
    {
        public static void Log(string message)
        {
            Console.WriteLine($"INFO: {message}");
        }

        public static void Log(string message, string level)
        {
            Console.WriteLine($"{level}: {message}");
        }

        public static void Log(string message, string level, DateTime time)
        {
            Console.WriteLine($"{time} | {level}: {message}");
        }

        static void Main(string[] args)
        {
            Log("Application Started");
            Console.WriteLine("-------------------");
            Log("Manage Memory", "WARNING");
            Console.WriteLine("-------------------");
            Log("System Crash", "ERROR", DateTime.Now);
        }
    }
}
