using KnowledgeCheck1_Calculator;
using System;
using System.Collections.Generic;

namespace Action
{
    public class Actions
    {
        List<int> numbers = new List<int>();
        public List<int> PromptUser()
        {
            Console.WriteLine("Enter 2 integers.");
            var numbers = GetNumbers();
            return numbers;
        }

        private List<int> GetNumbers()
        {
            Console.Write("First integer: ");
            var numberOne = (Console.ReadLine());
            Console.Write("Second integer: ");
            var numberTwo = (Console.ReadLine());
            numbers = PopulateList(numberOne, numberTwo);
            return numbers;
        }

        private List<int> PopulateList(string numberOne, string numberTwo)
        {
            numbers.Clear();
            if (int.TryParse(numberOne, out int numOne) && int.TryParse(numberTwo, out int numTwo))
            {
                numbers.Add(numOne);
                numbers.Add(numTwo);
            }
            else
            {
                numbers.Add(0);
                numbers.Add(0);
                Utilities.valid = false;
            }
            return numbers;
        }
    }
}
