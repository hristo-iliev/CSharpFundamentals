//// Write a program to check if in a given expression the brackets are put correctly.
//// Example of correct expression: ((a+b)/5-d).
//// Example of incorrect expression: )(a+b)).


namespace _03CorrectBrackets
{
    using System;
    using System.Text;

    public class CorrectBrackets
    {
        public static bool IfBracketsArePutCorrectly(string input)
        {
            bool correctExpression = false;

            StringBuilder expression = new StringBuilder();  
            expression.Append(input);

            for (int i = 0; i < expression.Length; )
            {
                if (expression[i] == '(')           
                {
                    expression.Remove(i,1);           

                    bool bracketFound = false;

                    for (int j = i; j < expression.Length; j++) 
                    {
                        if (expression[j] == ')') 
                        {
                            bracketFound = true;
                            expression.Remove(j,1);
                            break;
                        }
                    }
                    if (!bracketFound)
                    {
                        return correctExpression;
                    }
                }
                else
                {
                    i++;
                }
            }

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(' || expression[i] == ')')      
                {
                    correctExpression = false;
                }
                else
                {
                    correctExpression = true;
                }
            }

            return correctExpression;
        }

        public static void Main()
        {
            Console.WriteLine("Enter an expression:");
            string input = Console.ReadLine();          

            bool correct = IfBracketsArePutCorrectly(input);
            Console.WriteLine();
            if (correct == true)
            {
                Console.WriteLine("The brackets are put correctly :)");
            }
            else
            {
                Console.WriteLine("The brackets aren't put correctly :(");
            }
        }
    }
}
