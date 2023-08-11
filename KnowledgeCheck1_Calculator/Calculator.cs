namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        public int Operate(int operation, int first, int second)
        {
            if (Utilities.valid)
            {
                switch (operation)
                {
                    case 1: return first + second;
                    case 2: return first - second;
                    case 3: return first * second;
                    case 4: return first / second;
                    default:
                        Utilities.InvalidInputMsg();
                        return 0;
                }
            }
            else
            {
                Utilities.InvalidInputMsg("You must enter two integers.");
                return 0;
            }
        }
    }
}
