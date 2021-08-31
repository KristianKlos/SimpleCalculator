using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the menu loop
            bool menuLoop = true;

            //Visual Menu
            while (menuLoop)
            {
                Console.Clear();
                Console.WriteLine("Simple Calculator by Kristian Klos"
                                    + "\n----------------------------------"
                                    + "\nChoose your arithmetic:"
                                    + "\n"
                                    + "\n1. Addition"
                                    + "\n2. Subtraction"
                                    + "\n3. Multiplication"
                                    + "\n4. Division"
                                    + "\n"
                                    + "\n9. Exit");

                int selection = AskUserForNumber("number");

                //Switch Menu
                switch (selection)
                {
                    case 1:

                        Addition();
                        PressToClear();
                        break;

                    case 2:
                        Subtraction();
                        PressToClear();
                        break;

                    case 3:
                        Multiplication();
                        PressToClear();
                        break;

                    case 4:
                        Division();
                        PressToClear();
                        break;

                    case 9:
                        menuLoop = false;
                        Console.WriteLine("Shutting down...");
                        PressToExit();
                        break;

                    default:
                        Console.WriteLine("Invalid selection");
                        PressToSelect();
                        break;
                }

            }
        }//End of main method

        //Input
        static string AskUserFor(string what)
        {
            Console.Write("\nPlese enter " + what + ": ");

            string userInput = Console.ReadLine();

            return userInput;

        }

        //Converting to number
        static int AskUserForNumber(string what)
        {
            bool wasNotNumber = true;
            int number = 0;
            do
            {
                wasNotNumber = !int.TryParse(AskUserFor(what), out number);

            } while (wasNotNumber);

            return number;
        }

        //Add
        static void Addition()
        {
            double n1 = AskUserForNumber("first number");
            double n2 = AskUserForNumber("second number");

            Console.WriteLine("---------------------" +
                            $"\nResult: {n1} + {n2} = " + (n1 + n2));
        }

        //Sub
        static void Subtraction()
        {
            double n1 = AskUserForNumber("first number");
            double n2 = AskUserForNumber("second number");

            Console.WriteLine("---------------------" +
                            $"\nResult: {n1} - {n2} = " + (n1 - n2));
        }

        //Multi
        static void Multiplication()
        {
            double n1 = AskUserForNumber("first number");
            double n2 = AskUserForNumber("second number");

            Console.WriteLine("---------------------" + 
                            $"\nResult: {n1} * {n2} = " + (n1 * n2));

        }

        //Div with non-zero devisor check
        static void Division()
        {
            double n1 = AskUserForNumber("first number");
            double n2 = AskUserForNumber("second number");

        //Non-zero devisor check
            while (n2 == 0)
            {
                Console.WriteLine("I'm afraid i can't let you do that");
                n2 = AskUserForNumber("second number");

            }
            Console.WriteLine("---------------------" +
                            $"\nResult: {n1} / {n2} = " + (n1 / n2));


        }

        //Clearing the last calculation
        static void PressToClear()
        {
            Console.WriteLine("\nPress any key to clear calculation.");
            Console.ReadKey();
        }

        //Exit message
        static void PressToExit()
        {
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }

        //Back to selecting arithmetic
        static void PressToSelect()
        {
            Console.WriteLine("\nPress any key to select again.");
            Console.ReadKey();
        }
    }
}
