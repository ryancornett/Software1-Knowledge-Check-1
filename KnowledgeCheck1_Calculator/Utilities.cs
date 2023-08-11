using System;
using System.Collections.Generic;

namespace KnowledgeCheck1_Calculator
{
    public abstract class Utilities
    {
        public static bool valid = true;
        public static bool run = true;

        public static string DisplayApp()
        {
            Console.WriteLine("Enter 1 for addition, 2 for subtraction, 3 for multiplication, or 4 for division (0 to exit):");
            return Console.ReadLine();
        }

        public static Dictionary<int, string> operation = new Dictionary<int, string>()
            {
                { 1, "+" }, { 2, "-" }, { 3, "*" }, { 4, "/" }
            };

        public static void InvalidInputMsg(string msg = "Please try again.")
        {
            Console.WriteLine($"Invalid input. {msg}");
        }
    }
}
