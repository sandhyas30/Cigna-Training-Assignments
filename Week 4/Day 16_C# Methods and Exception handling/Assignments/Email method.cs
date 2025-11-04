using System;

namespace Assignment
{
    internal class Program
    {
        static void sendEmail(string receiver, string message, string sender="cigna@gmail.com", string subject="No Subject",bool isImportant=false)
        {
            Console.WriteLine("Email sent successfully.");

            Console.WriteLine($"From : {sender}");
            Console.WriteLine($"To : {receiver}");
            Console.WriteLine($"Subject : {subject}");
            Console.WriteLine($"Message : {message}");
            Console.WriteLine($"isImportant : {(isImportant ? "yes": "no")}");
            Console.WriteLine();
        }
    
   
        static void Main(string[] args)
        {
            sendEmail("genpact@gmail.com", "Hi!!");
            sendEmail("deloitte@gmail.com", "Hello, how are you ?", "cigna@gmail.com", "Greeting", true);
        }
    }
}
