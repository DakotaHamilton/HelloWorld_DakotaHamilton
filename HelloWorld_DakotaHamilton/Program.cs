using System; // Console Launch

namespace HelloWorld_DakotaHamilton // Document Name
{
    class Program // C# Classification Type
    {
        static void Main(string[] args) // Main Console String
        {
            Console.WriteLine("What is your First Name?");// First Name Question
            string firstName = Console.ReadLine();// First Name Input
            Console.WriteLine("What is your Last Name?");// Last Name Question
            string lastName = Console.ReadLine();// Last Name Input
            Console.WriteLine($"Hello,{firstName} {lastName}!");// User Greeting
            Console.WriteLine("Have fun using Windows :)");// User Greeting Extra Text
        }
    }
}