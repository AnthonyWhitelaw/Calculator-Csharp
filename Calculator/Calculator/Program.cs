using System;
using System.Diagnostics;

public class Calculator
{
    public static void Main()
    {
        int count = 1;
        bool exit = false;

        while (!exit)
        {
            double num1, num2, answer;
            string operand;

            if (count <= 1)
                using (Process.Start("notepad.exe", @"E:\Calculator\Calculator\InstructionsForUser.txt"))

                    Console.WriteLine("Read instructions on the notepad to see how this calculator works");

            do
            {
                Console.WriteLine("Please enter the first number: ");
            }
            while (!double.TryParse(Console.ReadLine(), out num1));

            Console.Write("Please enter an operand (+, -, /, *): ");
            operand = Console.ReadLine();

            do
            {
                Console.Write("Please enter the second number: ");
            }
            while (!double.TryParse(Console.ReadLine(), out num2));

            switch (operand)
            {
                case "-":
                    answer = num1 - num2;
                    break;
                case "+":
                    answer = num1 + num2;
                    break;
                case "/":
                    answer = num1 / num2;
                    break;
                case "*":
                    answer = num1 * num2;
                    break;
                default:
                    answer = 0;
                    Console.WriteLine("Error !");
                    break;
            }

            Console.WriteLine(string.Format("{0} {1} {2} = {3}", num1, operand, num2, answer));

            Console.Write("Need to use me again? Y/N");

            if (Console.ReadLine().ToLower() == "n")
                exit = true;

            count++;
        }
    }
}

