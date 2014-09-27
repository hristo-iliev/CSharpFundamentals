using System;
using System.Collections.Generic;
using System.Linq;
class MultiTaskProgram
{
    //Write a program that can solve these tasks:
    //Reverses the digits of a number
    //Calculates the average of a sequence of integers
    //Solves a linear equation a * x + b = 0
	//Create appropriate methods.
	//Provide a simple text-based menu for the user to choose which task to solve.
	//Validate the input data:
    //The decimal number should be non-negative
    //The sequence should not be empty
    //a should not be equal to 0

    static void ReverseDigits(decimal number)
    {
        string num = number.ToString();

        string newNum = "";

        for (int i = 0; i < num.Length; i++)
        {
            newNum += num[num.Length - (i + 1)];
        }

        Console.WriteLine("The reversed number is: " + newNum);
    }

    static void Average(decimal[] arr)
    {
        decimal result = new decimal();

        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
        }

        Console.WriteLine("The average number is: " + result/2);


    }

    static void SolvingLinearEquation(decimal a, decimal b)
    {
        if (a == 0)
        {
            Console.WriteLine("The equation has no solution.");
        }
        else
        {
            decimal x = -b / a;
            Console.WriteLine("x = " + x);
        }
        
        
    }

    static void UserInterface()
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine();
        Console.WriteLine("1. Reverse the digits of a number.");
        Console.WriteLine("2. Calculate the average of a sequence of integers.");
        Console.WriteLine("3. Solve a linear equation a * x + b = 0");
        Console.WriteLine();


        bool res = new bool();
        int choice = new int();

        do
        {
            Console.WriteLine("Type the corresponding task number.");
            Console.Write("Your choice: ");
            string input = Console.ReadLine();
            res = int.TryParse(input, out choice);
        }
        while (!res || choice < 1 || choice > 3);
        {
            if (choice == 1)
            {
                Console.WriteLine();
                Console.Write("Enter a number: ");
                decimal number = decimal.Parse(Console.ReadLine());

                Console.WriteLine();
                ReverseDigits(number);



                
                                                            
                                                            
            }
            else if (choice == 2)
            {
                Console.WriteLine();
                Console.WriteLine("You are looking for the average of how many numbers: ");
                int count = int.Parse(Console.ReadLine());

                decimal[] sequence = new decimal[count];

                Console.WriteLine("Enter the numbers:");
                for (int i = 0; i < count; i++)
                {
                    sequence[i] = decimal.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                Average(sequence);

            }
            else if  (choice == 3)
            {
                Console.WriteLine();
                Console.WriteLine("Enter the values of A and B");
                Console.Write("A = ");
                decimal a = decimal.Parse(Console.ReadLine());
                Console.Write("B = ");
                decimal b = decimal.Parse(Console.ReadLine());
                
                Console.WriteLine();
                SolvingLinearEquation(a, b);

            }

            Console.WriteLine();

            do
            {
                Console.WriteLine("For taking another task, press 1.");
                Console.WriteLine("For exit press 2.");
                string input = Console.ReadLine();
                res = int.TryParse(input, out choice);

            }
            while (!res || choice < 1 || choice > 2);
            {
                if (choice == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine(new string('-', 80));
                    UserInterface();
                }
                else
                {
                    Console.WriteLine(new string('~', 80));
                    Console.WriteLine("{0, 45}", "Goodbye Boss!");
                    Console.WriteLine(new string('~', 80));
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }

        }
    }

    static void Main()
    {
        Console.WriteLine(new string('~', 80));
        Console.WriteLine("{0, 45}", "Hello Boss!");
        Console.WriteLine(new string('~', 80));

        UserInterface();
                      
    }
}

