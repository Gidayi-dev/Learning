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

            // Numbers
            // integers
            int a = 34;
            int b = 90;
            int d = 105;
            // operations
            int c = b - a;
            Console.WriteLine(c);
            int e = d + a / (c) % 2;
            Console.WriteLine(e);
            int Max = int.MaxValue;
            int Min = int.MinValue;

            Console.WriteLine($"The Maximum value is {Max} and the Minimum value is {Min}");

            // Double
            double num1 = 5;
            double num2 = 4;
            double num3 = 2;
            double num4 = (num1 + num2) / num3;
            Console.WriteLine(num4);
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            double num5 = 1.0;
            double num6 = 3.0;
            Console.WriteLine(num5 / num6);

            decimal num7 = 1.0M;
            decimal num8 = 3.0M;
            Console.WriteLine(num7 / num8);
        }
    }
}