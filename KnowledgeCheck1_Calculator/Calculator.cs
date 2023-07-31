using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return first - second;
        }

        public int Multiply(int first, int second)
        {
            return first * second;
        }

        public double Divide(double first, double second)
        {
            return first / second;
        }

        public List<int> GetNumbers()
        {
            List<int> numbers = new List<int>();
            Console.Write("First integer: ");
            var number1 = (Console.ReadLine());
            Console.Write("Second integer: ");
            var number2 = (Console.ReadLine());
            if (int.TryParse(number1, out int numOne) && int.TryParse(number2, out int numTwo))
            {
                numbers.Add(numOne);
                numbers.Add(numTwo);
            }
                     
            return numbers;
        }
    }
}
