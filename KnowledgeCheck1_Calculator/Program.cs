using KnowledgeCheck1_Calculator;
using Action;
using System;

var calc = new Calculator();
var act = new Actions();

while (Utilities.run)
{
    string input = Utilities.DisplayApp();
    if (int.TryParse(input, out int selection))
    {
        if (selection >= 1 && selection < 5)
        {
            var numbers = act.PromptUser();
            var result = calc.Operate(selection, numbers[0], numbers[1]);
            if (Utilities.valid == true)
            {
                Console.WriteLine($"{numbers[0]} {Utilities.operation[selection]} {numbers[1]} = {result}");
            }
        }
        else if (selection == 0)
        {
            Utilities.run = false;
            Environment.Exit(0);
        }
        else Utilities.InvalidInputMsg("You must select 0, 1, 2, 3, or 4.");
    }
    else Utilities.InvalidInputMsg();
}