using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Gidayi");

            // Variables
            // String
            string aFriend = "Gidayi";
            Console.WriteLine(aFriend);

            // String interpolation
            Console.WriteLine($"Hello, {aFriend}");

            string firstFriend = "Millyannah";
            string secondFriend = "Gidayi";
            Console.WriteLine($"My first name is {firstFriend} and my last name is {secondFriend}");

            // Trim
            string name = "             Just edits           ";
            Console.WriteLine($"[{name}]");

            string trimmedName = name.TrimStart();
            Console.WriteLine($"[{trimmedName}]");

            string trimmedeName = name.TrimEnd();
            Console.WriteLine($"[{trimmedeName}]");

            string trimedName = name.Trim();
            Console.WriteLine($"[{trimedName}]");

            // Replace
            string sayHello = "Hello, Moses";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);
            Console.WriteLine(sayHello.ToLower());
            Console.WriteLine(sayHello.ToUpper());

            // Search strings
            string lyrics = "Baby is 6:45, Baby I am barely alive, Am thinking its better if you drive";
            Console.WriteLine(lyrics);
            // contains returns a boolen value true or false
            Console.WriteLine(lyrics.Contains("barely"));
            Console.WriteLine(lyrics.Contains("conquer"));
            Console.WriteLine(lyrics.Contains("baby"));
            Console.WriteLine(lyrics.StartsWith("Baby"));
            Console.WriteLine(lyrics.EndsWith("drive"));
        }
    }
}