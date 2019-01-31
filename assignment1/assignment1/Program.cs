using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        public static int ValidMenuSelection()
        {
            string ValidKeyInput = "";
            bool SelectOption = false;
            while (SelectOption == false)
            {
                Console.WriteLine("1->Get Rectangle Length");
                Console.WriteLine("2->Change Rectangle Length");
                Console.WriteLine("3->Get Rectangle Width");
                Console.WriteLine("4->Change Rectangle Width");
                Console.WriteLine("5->Get Rectangle Perimeter");
                Console.WriteLine("6->Get Rectangle Area");
                Console.WriteLine("7->Exit\n");

                Console.WriteLine("Please select any one option\n");
                ValidKeyInput = Console.ReadLine();


                if (ValidKeyInput != "1" &&
                    ValidKeyInput != "2" &&
                    ValidKeyInput != "3" &&
                    ValidKeyInput != "4" &&
                    ValidKeyInput != "5" &&
                    ValidKeyInput != "6" &&
                    ValidKeyInput != "7")
                {
                    Console.WriteLine("You selected a wrong option, please try again:\n");
                }
                else
                {
                    SelectOption = true;
                }
            }
            Console.WriteLine();
            return int.Parse(ValidKeyInput);

        }

        public static int InputValidation(string chosenNumber)
        {
            int NumberOption = 1;
            bool NotValid = false;

            while (NotValid == false)
            {
                Console.WriteLine($"Please enter the {chosenNumber}:");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out NumberOption);

                if (result == false)
                {
                    Console.WriteLine("That's not a valid input please, please try again.\n");
                }

                else
                {
                    NotValid = true;
                    Console.WriteLine($"Your {chosenNumber} has been changed to: {NumberOption}.\n");
                }
            }

            return NumberOption;
        }

        static void Main(string[] args)
        {
            rectangle rc = new rectangle();
            bool validSelection = false;
            string rectSelection;
            int selection;

            while (validSelection == false)
            {
                Console.WriteLine("1 = Use random numbers between 0 and 100 for your calculation\n");
                Console.WriteLine("2 = Provide your desired numbers\n");
                Console.WriteLine("Select an item from menu to continue:");
                rectSelection = Console.ReadLine();
                Console.WriteLine();

                if (rectSelection != "1" && rectSelection != "2")
                {
                    Console.WriteLine("please select a valid option and try again.\n");
                }
                else if (int.Parse(rectSelection) == 1)
                {
                    validSelection = true;
                    Random r = new Random();
                    double Length;
                    double Width;

                    Length = Math.Round((r.NextDouble() * 100), 0);
                    Width = Math.Round((r.NextDouble() * 100), 0);

                    Console.WriteLine($"Your random numbers are {Length} and {Width}.\n");
                    rectangle customCalc = new rectangle(Length, Width);
                    rc = customCalc;
                     
                }
                else if (int.Parse(rectSelection) == 2)
                {
                    validSelection = true;

                    double Length;
                    double Width;
                    Length = InputValidation("Length");
                    Width = InputValidation("Width");

                    Console.WriteLine($"Your custom numbers are {Length} and {Width}.\n");
                    rectangle customCalc = new rectangle(Length, Width);
                    rc = customCalc;
                }
            }


            selection = ValidMenuSelection();

            while (selection != 9)
            {
                int result;

                switch (selection)
                {
                    case 1:
                        Console.WriteLine($"Length of Rectangle is: {rc.Getrectanglelength()}\n");
                        break;
                    case 2:
                        result = InputValidation("Length");
                        rc.ChangerectangleLength(result);
                        break;
                    case 3:
                        Console.WriteLine($"Width of Rectangle is: {rc.GetrectangleWidth()}\n");
                        break;
                    case 4:
                        result = InputValidation("Width");
                        rc.ChangerectangleWidth(result);
                        break;
                    case 5:
                        Console.WriteLine($"The perimeter of Rectangle is:{rc.GetrectanglePerimeter()}\n ");

                        break;
                    case 6:
                        Console.WriteLine($"The area of rectangle is {rc.GetrectangleArea()}\n");
                        break;
                    case 7:


                    default:
                        break;
                }

                selection = ValidMenuSelection();

            }

        }
    }
}
