using System;

namespace SimpleCalculator
{
    class Program
    {
        //Main/Start Method
        static void Main(string[] args)
        {

            //Variables
            bool menuLoop = true;
            double input1;
            double input2;

            //Looping the Menu
            while (menuLoop)
            {
                Console.Clear();
                ConsoleMenu();
                //selecting switch case
                double selection = AskUserForNumber("your selection");

                //Switch Menu
                switch (selection)
                {
                    case 1:
                        TwoNumbers(out input1, out input2);
                        Addition(input1, input2);
                        PressToMessage(1);
                        break;

                    case 2:
                        TwoNumbers(out input1, out input2);
                        Subtraction(input1, input2);
                        PressToMessage(1);
                        break;

                    case 3:
                        TwoNumbers(out input1, out input2);
                        Multiplication(input1, input2);
                        PressToMessage(1);
                        break;

                    case 4:
                        TwoNumbers(out input1, out input2);
                        Division(input1, input2);
                        PressToMessage(1);
                        break;

                    case 9:
                        menuLoop = false;
                        PressToMessage(3);
                        break;

                    default:
                        PressToMessage(default);
                        PressToMessage(2);

                        break;
                }


            }
        }

        //Console Menu
        static void ConsoleMenu()
        {
            Console.WriteLine("Simple Calculator by Kristian Klos v1.1");
            Console.WriteLine("-----------------------------------------"
                                    + "\nChoose your arithmetic:"
                                    + "\n"
                                    + "\n1. Addition"
                                    + "\n2. Subtraction"
                                    + "\n3. Multiplication"
                                    + "\n4. Division"
                                    + "\n"
                                    + "\n9. Exit");
        }

        //Input
        static string AskUserFor(string what)
        {
            Console.Write("\nPlese enter " + what + ": ");

            string userInput = Console.ReadLine();

            return userInput;

        }

        //Convert to double
        static int AskUserForNumber(string what)
        {
            bool wasNotNumber = true;
            int input = 0;
            do
            {

                wasNotNumber = !int.TryParse(AskUserFor(what), out input);

            } while (wasNotNumber);

            return input;
        }

        //Ask for two numbers
        static void TwoNumbers(out double input1, out double input2)
        {
            input1 = AskUserForNumber("first number");
            input2 = AskUserForNumber("second number");
        }

        //Arithmetics-----------------------------------------

        //Add
        static void Addition(double input1, double input2)
        {
            Console.WriteLine("-----------------------"
                            + $"\nYour result: {input1} + {input2} = " + (input1 + input2));
        }

        //Sub
        static void Subtraction(double input1, double input2)
        {

            Console.WriteLine("-----------------------"
                            + $"\nResult: {input1} - {input2} = " + (input1 - input2));
        }

        //Multi
        static void Multiplication(double input1, double input2)
        {


            Console.WriteLine("-----------------------"
                            + $"\nResult: {input1} * {input2} = " + (input1 * input2));

        }

        //Div (zero devisor check)
        static void Division(double input1, double input2)
        {


            //Non-zero devisor check
            while (input2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("I'm afraid i can't let you do that");
                Console.ResetColor();
                input2 = AskUserForNumber("second number");

            }
            Console.WriteLine("-----------------------"
                             + $"\nResult: {input1} / {input2} = " + (input1 / input2));
        }

        //Switch with all return-messages
        static void PressToMessage(int message)
        {
            int press = message;
            switch (press)
            {
                case 1:
                    Console.WriteLine("\nPress any key to clear calculation.");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("\nPress any key to go back to selection.");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("Shutting down...");
                    break;
                default:
                    Console.WriteLine("Invalid Selection.");
                    break;


            }
        }


    }
}
