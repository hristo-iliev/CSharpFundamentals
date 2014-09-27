//* Write a program that calculates the value of given arithmetical expression.
//  The expression can contain the following elements only:
//  Real numbers, e.g. 5, 18.33, 3.14159, 12.6
//  Arithmetic operators: +, -, *, / (standard priorities)
//  Mathematical functions: ln(x), sqrt(x), pow(x,y)
//  Brackets (for changing the default priorities)

namespace _07Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Text;   

    public class Calculator
    {
        private static List<char> usedSymbols = new List<char> {'+', '-', '*', '/', '(', ')', ',' };
        private static List<string> functions = new List<string> { "pow", "sqrt", "ln" };
        private static List<string> operators = new List<string> { "+", "-", "*", "/"};

        public static string TrimWhitespace(string input)
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    output.Append(input[i]);
                }
            }

            return output.ToString();
        }

        public static List<string> StringToListOfTokens(string input)
        {
            List<string> output = new List<string>();
            StringBuilder number = new StringBuilder();
            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '-' && (i == 0 || input[i-1] == ',' || input[i-1] == '('))
                {
                    number.Append(input[i]);
                    i++;
                    while (true)
                    {
                        if (char.IsDigit(input[i]) || input[i] == '.')
                        {
                            number.Append(input[i]);

                            if (i + 1 < input.Length)
                            {
                                i++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            i--;
                            break;
                        }
                    }

                    output.Add(number.ToString());
                    number.Clear();
                }
                else if (char.IsDigit(input[i]))
                {
                    while (true)
                    {
                        if (char.IsDigit(input[i]) || input[i] == '.')
                        {
                            number.Append(input[i]);

                            if (i + 1 < input.Length)
                            {
                                i++;
                            }
                            else
                            {
                                break;
                            }
                            
                        }
                        else
                        {
                            i--;
                            break;
                        }
                    }

                    output.Add(number.ToString());
                    number.Clear();
                }
                else if (usedSymbols.Contains(input[i]))
                {
                    output.Add(input[i].ToString());
                }
                else if (input.Substring(i, 2).ToLower() == "ln")
                {
                    output.Add("ln");
                    i++;
                }
                else if (input.Substring(i, 4).ToLower() == "sqrt")
                {
                    output.Add("sqrt");
                    i += 3;
                }
                else if (input.Substring(i, 3).ToLower() == "pow")
                {
                    output.Add("pow");
                    i += 2;
                }
                else
                {
                    throw new ArgumentException("Yoda said: Bullshit you wrote!");
                }
            }

            return output;
        }

        public static int Precedence(string input)
        {        
            if (input == "*" || input == "/")
            {
                return 2;
            }

            return 1;
        }

        public static Queue<string> ConvertToRPN(List<string> input)
        {
            Queue<string> output = new Queue<string>();
            Stack<string> currentStack = new Stack<string>();

            for (int i = 0; i < input.Count; i++)
            {
                double num;

                if (double.TryParse(input[i], out num))
                {
                    output.Enqueue(input[i]);
                }
                else if (functions.Contains(input[i]))
                {
                    currentStack.Push(input[i]);
                }
                else if (input[i] == ",")
                {
                    if (!currentStack.Contains("("))
                    {
                        throw new ArgumentException("Caput brackets or comma!!!");
                    }

                    while (currentStack.Peek() != "(")
                    {
                        output.Enqueue(currentStack.Pop());
                    }
                                        
                }
                else if (operators.Contains(input[i]))    // MOJE BI PROBLEMI!!!!!!
                {
                    while (currentStack.Count != 0 && operators.Contains(currentStack.Peek()) && Precedence(currentStack.Peek()) >= Precedence(input[i]))
                    {
                        output.Enqueue(currentStack.Pop());
                    }

                    currentStack.Push(input[i]);
                }
                else if (input[i] == "(")
                {
                    currentStack.Push("(");
                }
                else if (input[i] == ")")
                {
                    if (currentStack.Contains("("))
                    {
                        while (currentStack.Peek() != "(")
                        {
                            output.Enqueue(currentStack.Pop());
                        }
                        currentStack.Pop();
                        if (currentStack.Count != 0 && functions.Contains(currentStack.Peek()))
                        {
                            output.Enqueue(currentStack.Pop());
                        }
                    }
                    else
                    {
                        throw new ArgumentException("INVALID BRACKETS!!!!");
                    }                    
                }
            }

            while (currentStack.Count != 0)
            {
                output.Enqueue(currentStack.Pop());
            }

            return output;
        }

        public static double FinalResult(Queue<string> input)
        {
            Stack<double> stack = new Stack<double>();

            while (input.Count > 0)
            {
                string currentValue = input.Dequeue();
                double num;

                if (double.TryParse(currentValue, out num))
                {
                    stack.Push(num);
                }
                else if (functions.Contains(currentValue) || operators.Contains(currentValue))
                {
                    double one;
                    double two;

                    switch (currentValue)
                    {
                        case "+":
                            one = stack.Pop();
                            two = stack.Pop();
                            stack.Push(one + two);
                            break;
                        case "-":
                            one = stack.Pop();
                            two = stack.Pop();
                            stack.Push(two - one);
                            break;
                        case "*":
                            one = stack.Pop();
                            two = stack.Pop();
                            stack.Push(one * two);
                            break;
                        case "/":
                            one = stack.Pop();
                            two = stack.Pop();
                            stack.Push(two / one);
                            break;
                        case "pow":
                            one = stack.Pop();
                            two = stack.Pop();
                            stack.Push(Math.Pow(two, one));
                            break;
                        case "sqrt":
                            one = stack.Pop();
                            stack.Push(Math.Sqrt(one));
                            break;
                        case "ln":
                            one = stack.Pop();
                            stack.Push(Math.Log(one));
                            break;
                    }
                }               
            }

            if (stack.Count != 1)
            {
                throw new ArgumentException("Invalid input!");
            }
            else
            {
                return stack.Pop();
            }
        }

        public static void Main()
        {
            string input = Console.ReadLine();
            ////string input = "pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)";
            ////string input = "(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)";
            ////string input = "3+4 * 2 / (1 - 5)";
            ////string input = "2 + 1 - 12 /3";
            ////string input = "2  * 3 - 15 - (2+4)";
            ////string input = "-2.45 * PoW(-2.4,2) - ln(4)";
            ////string input = "glupost";

            string trimInput = TrimWhitespace(input);
            List<string> token = StringToListOfTokens(trimInput);
            Queue<string> finalInput = ConvertToRPN(token);

            Console.WriteLine(FinalResult(finalInput));
        }
    }
}
