using System;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter 2 integers to add");
                    var numbers = calculator.GetNumbers();

                    
                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");
                    numbers = calculator.GetNumbers();

                    try
                    {
                        Console.Write($"{numbers[0]} - {numbers[1]} = ");
                        Console.Write(calculator.Subtract(numbers[0], numbers[1]));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter 2 integers to multiply");
                    numbers = calculator.GetNumbers();

                    try
                    {
                        Console.Write($"{numbers[0]} * {numbers[1]} = ");
                        Console.Write(calculator.Multiply(numbers[0], numbers[1]));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide");
                    numbers = calculator.GetNumbers();

                    try
                    {
                        Console.Write($"{numbers[0]} / {numbers[1]} = ");
                        Console.Write(calculator.Divide(numbers[0], numbers[1]));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}