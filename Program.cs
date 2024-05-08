using System;
using System.ComponentModel.Design;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Midterm_CSI120


{
    internal class Program
    {
        static void Main(string[] args)
        {
   
          // Putting my name and date, and titles of midterm and app
            Console.WriteLine("Kady Tran - 05/07/2024");
            Console.WriteLine("Midterm CSI 120");
            Console.WriteLine("Personal Calculator");
            Menu(); // Calling method

        }// End of main

        public static void Problem1()
        {
            bool isRunning = true;
            do
            {

                /* You will ask the user for a number. Afterwards, you will ask the user what math operation they wouldlike to perform. Then you will ask for a second number. You will perform the math and display theresult.You do not need to continue to do math with this same value. You can ask them to enter a new number afterward */

                // Label the app
                Console.WriteLine("Welcome to the Basic Calculator");


                // Giving user options
                Console.WriteLine("Choose an option:");
                Console.WriteLine("+ - Addition");
                Console.WriteLine("- - Subtraction");
                Console.WriteLine("* - Multiplication");
                Console.WriteLine("/ - Division");
                Console.WriteLine("e - Exit Basic Calculator");
                string userResponse = Console.ReadLine();


                try // using try catch, if user enters an invalid number, catch will display an "Error" message
                {

                
                // Conditional statements for each option
                if (userResponse == "+") // Addition
                {
                    // Asking for first number
                    Console.Write("Please enter the first number: ");
                    double userFirstNumber = double.Parse(Console.ReadLine()); // Using a double so that it gives the user more numbers to work with

                    Console.Write("Please enter the second number: ");
                    double userSecondNumberForFirstNumber = double.Parse(Console.ReadLine());

                    double userAddition = userFirstNumber + userSecondNumberForFirstNumber;
                    Console.WriteLine("Equation: " + userFirstNumber + " + " + userSecondNumberForFirstNumber); //Displaying equation
                    Console.WriteLine("Your addition result is: " + userAddition); // Displaying result
                }
                else if (userResponse == "-") // Subtraction
                {
                    // Asking for first number
                    Console.Write("Please enter the first number: ");
                    double userFirstNumber = double.Parse(Console.ReadLine()); // Using a double so that it gives the user more numbers to work with

                    Console.Write("Please enter the second number: ");
                    double userSecondNumberForFirstNumber = double.Parse(Console.ReadLine());

                    double userSubtraction = userFirstNumber - userSecondNumberForFirstNumber;
                    Console.WriteLine("Equation: " + userFirstNumber + " - " + userSecondNumberForFirstNumber);
                    Console.WriteLine("Your subtraction result is: " + userSubtraction);
                }
                else if (userResponse == "*") // Multiplication
                {
                    // Asking for first number
                    Console.Write("Please enter the first number: ");
                    double userFirstNumber = double.Parse(Console.ReadLine()); // Using a double so that it gives the user more numbers to work with

                    Console.Write("Please enter the second number: ");
                    double userSecondNumberForFirstNumber = double.Parse(Console.ReadLine());

                    double userMultiplication = userFirstNumber * userSecondNumberForFirstNumber;
                    Console.WriteLine("Equation: " + userFirstNumber + " x " + userSecondNumberForFirstNumber);
                    Console.WriteLine("Your multiplication result is: " + userMultiplication);
                }
                else if (userResponse == "/") // Divison
                {
                    // Asking for first number
                    Console.Write("Please enter the first number: ");
                    double userFirstNumber = double.Parse(Console.ReadLine()); // Using a double so that it gives the user more numbers to work with

                    Console.Write("Please enter the second number: ");
                    double userSecondNumberForFirstNumber = double.Parse(Console.ReadLine());

                    double userDivison = userFirstNumber / userSecondNumberForFirstNumber;
                    Console.WriteLine("Equation: " + userFirstNumber + " / " + userSecondNumberForFirstNumber);
                    Console.WriteLine("Your Division result is: " + userDivison);
                }
                else if (userResponse == "e" || userResponse == "E")
                {
                    Menu();
                }
                else if (userResponse != "+" && userResponse != "-" && userResponse != "*" && userResponse != "/" && userResponse != "e" && userResponse != "E")
                {
                    Console.WriteLine("Please choose a valid option");

                } // End of if else statement
                }
                catch
                {
                    Console.WriteLine("Your input was invalid. Please enter a valid number.");
                }
            } while (isRunning); // This will stay onto the app until the user chooses to exit

        } // End of Problem1()

        public static void Problem2()
        {
            // A finance calculator - that lets the user do 3 equations. You will ask for the correct info and display the results.
            //  The result will be formatted with the right currency sign

            // Net Income – Ask the for the users income and costs, display their net income.
            // Rule of 72 – Ask the user for the rate of interest, display how many years it’ll take to double their money.
            // Net Worth – Ask the user for the asset and liabilities and display their net worth.

            bool isRunning = true;
            do
            {
                // Labeling the app
                Console.WriteLine("Welcome to the Finance Calculator");

                // Giving user options
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1 - Net Income");
                Console.WriteLine("2 - Rule of 72");
                Console.WriteLine("3 - Net Worth");
                Console.WriteLine("e - Exit Finance Calculator");
                string userResponse = Console.ReadLine();

                try
                {
                    if (userResponse == "1") // Net Income
                    {
                        Console.WriteLine("Net Income"); // Labeling for organization
                        Console.Write("Please enter your income: "); // Asking user input
                        double userNetIncome = double.Parse(Console.ReadLine());

                        Console.Write("Please enter your costs: ");
                        double userCosts = double.Parse(Console.ReadLine());
                        userNetIncome = userNetIncome - userCosts; // equation for net income is net income - cost

                        Console.WriteLine("Your net income: " + userNetIncome.ToString("c"));
                    }
                    else if (userResponse == "2") // Rule of 72
                    {
                        Console.WriteLine("Rule of 72");
                        Console.Write("Please enter the expected interest rate: "); // asking for user input
                        double userInterestRate = double.Parse(Console.ReadLine());

                        double ruleOfSeventyTwo = 72; // setting variable 

                        // double userRuleofSeventyTwoResult = ruleOfSeventyTwo / userInterestRate;
                        double userRuleofSeventyTwoResult = Math.Round((ruleOfSeventyTwo / userInterestRate), 2); // the equation for rule of 72

                        // I made the user interest rate be divided by 100 because if a user puts in "5", it will come out as 500% instead of 5%
                        Console.WriteLine("At an interest rate of " + (userInterestRate / 100).ToString("p") + " it will take " + userRuleofSeventyTwoResult + " years to double your money");
                    }
                    else if (userResponse == "3") // Net Worth
                    {
                        Console.WriteLine("Net Worth");
                        Console.Write("Please enter the value of your assets: "); // asking for user input
                        double userAssets = double.Parse(Console.ReadLine());

                        Console.Write("Please enter the value of your liabilities: ");
                        double userLiabilities = double.Parse(Console.ReadLine());

                        double userNetWorth = userAssets - userLiabilities; // equation for net worth

                        Console.WriteLine("Your net worth: " + userNetWorth.ToString("c")); // adding the tostring to display currency sign
                    }
                    else if (userResponse == "e" || userResponse == "E")
                    {
                        Menu(); // this sends user back to menu
                    }
                    else if (userResponse != "1" && userResponse != "2" && userResponse != "3" && userResponse != "e" && userResponse != "E")
                    {
                        Console.WriteLine("Please choose a valid option"); 

                    } // End of if else statement
                }
                catch
                {// this displays if the user doesnt input a valid number
                    Console.WriteLine("Your input was invalid. Please enter a valid number.");
                }
            } while (isRunning);

            } // End of Problem2()

        public static void Problem3()
        {

            bool isRunning = true;
            do
            {
                Console.WriteLine("Welcome to the Geometry Calculator");
            // A geometry calculator – You will give the user 4 options: Square, Rectangle, Circle, and the volume of a right circular cone
            /*
            o Square – Ask the user for a side, display the area and perimeter
            o Rectangle – Ask for the length and width, display the area and perimeter
            o Circle – Ask for the radius, display the area and circumference
            o Right Circular Cone – Ask for the radius and height of a cone, and display the volume
             */

            // Giving user options
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1 - Square");
            Console.WriteLine("2 - Rectangle");
            Console.WriteLine("3 - Circle");
            Console.WriteLine("4 - Right Circular Cone");
            Console.WriteLine("e - Exit");
            string userResponse = Console.ReadLine();


                try // for if the user doesn't put a valid number
                {


                    // Conditional statements for each option
                    if (userResponse == "1") // Square
                    {
                        Console.WriteLine("Square");
                        Console.Write("Please enter a side: "); // asking for user input
                        double userSide = double.Parse(Console.ReadLine()); // storing user input

                        double userPerimeter = Math.Round((userSide * 4), 2);
                        double userArea = Math.Round((userSide * userSide), 2);

                        // displaying results
                        Console.WriteLine("Perimeter: " + userPerimeter);
                        Console.WriteLine("Area: " + userArea);

                    }
                    else if (userResponse == "2") // Rectangle
                    {
                        Console.WriteLine("Rectangle");
                        Console.Write("Please enter a length: "); // asking for user input 
                        double userLength = double.Parse(Console.ReadLine()); // storing user input

                        Console.Write("Please enter a width: ");
                        double userWidth = double.Parse(Console.ReadLine());

                        double userPerimeter = Math.Round((2 * (userLength + userWidth)), 2);
                        double userArea = Math.Round((userLength * userWidth), 2);


                        // displaying results
                        Console.WriteLine("Perimeter: " + userPerimeter);
                        Console.WriteLine("Area: " + userArea);
                    }
                    else if (userResponse == "3") // Circle
                    {
                        Console.WriteLine("Circle");
                        Console.Write("Please enter a radius: "); // asking user input
                        double userRadius = double.Parse(Console.ReadLine()); // storing user input

                        double userArea1 = userRadius * Math.PI;
                        double userArea = Math.Round((userArea1 * userArea1), 2);

                        double userCircumference = Math.Round((2 * Math.PI * userRadius), 2);

                        // displaying results
                        Console.WriteLine("Area: " + userArea);
                        Console.WriteLine("Circumference: " + userCircumference);

                    }
                    else if (userResponse == "4") // Right Circular Cone
                    {
                        Console.WriteLine("Right Circular Cone");
                        Console.Write("Please enter a radius: ");
                        double userRadius = double.Parse(Console.ReadLine());

                        Console.Write("Please enter a height: ");
                        double userHeight = double.Parse(Console.ReadLine());



                        double userVolume = Math.Round(((Math.PI * userRadius * userRadius * userHeight) / 3), 2);


                        Console.WriteLine("Volume: " + userVolume);
                    }
                    else if (userResponse == "e" || userResponse == "E")
                    {
                        Menu(); // sends user back to calculator menu
                    }
                    else if (userResponse != "1" && userResponse != "2" && userResponse != "3" && userResponse != "e" && userResponse != "E")
                    {
                        Console.WriteLine("Please choose a valid option");

                    } // End of if else statement
                }
                catch
                {
                    Console.WriteLine("Your input was invalid. Please enter a valid number."); // if user enters a non-numerical value
                }
            } while (isRunning);


        } // End of Problem3() 


        public static void Problem4()
        {

            //bool isRunning = true;
            //do
            //{
                // Request two integer values from the user x and y. These number will represent the coordinatepoints on the Cartesian Plane. The program thenshould output a message indicating which quadrant of the graph the point is in.


                // Label
                Console.WriteLine("Welcome to the Cartesian Plane");



                // if user doesn't put in a valid number, the try catch will display an "error" message
                try
                {

                    Console.Write("Please enter x (whole number): "); // asking user input
                    double userX = double.Parse(Console.ReadLine()); // storing user input

                    Console.Write("Please enter y (whole number): ");// asking user input
                    double userY = double.Parse(Console.ReadLine()); // storing user input

                    if (userX < 0 && userY < 0) // Quadrant 3 , (-,-)
                    {
                        Console.WriteLine("Your coordinates (" + userX + ", " + userY + ") are in Quadrant III");
                    }
                    else if (userX > 0 && userY > 0) // Quadrant I , ( +, +)
                    {
                        Console.WriteLine("Your coordinates (" + userX + ", " + userY + ") are in Quadrant I");
                    }
                    else if (userX < 0 && userY > 0) // Quadrant II , ( -, +)
                    {
                        Console.WriteLine("Your coordinates (" + userX + ", " + userY + ") are in Quadrant II");
                    }
                    else if (userX > 0 && userY < 0) // Quadrant IV , ( +, -)
                    {
                        Console.WriteLine("Your coordinates (" + userX + ", " + userY + ") are in Quadrant IV");
                    }
                    else if (userX == 0 && userY == 0) // point of origin (0,0)
                    {
                        Console.WriteLine("Your coordinates (" + userX + ", " + userY + ") are at the point of origin");
                    }
                    else if (userX == 0) // if the x coordinate is on 0
                    {
                        Console.WriteLine("Your coordinates (" + userX + ", " + userY + ") lies on the x-axis");
                    }
                    else if (userY == 0) // if the y coordinate is on 0
                    {
                        Console.WriteLine("Your coordinates (" + userX + ", " + userY + ") lies on the y-axis");
                    } // End of if else statement
                }
                catch
                {
                    Console.WriteLine("Your input was invalid. Please enter a valid number.");
                }
           // } while (isRunning);

        } // End of Problem4()



        public static void Menu()
        {
            bool isRunning = true;

            do
            {// Start menu, what you see first
                Console.WriteLine("1 - Basic Calculator");
                Console.WriteLine("2 - Finance Calculator");
                Console.WriteLine("3 - Geometry Calculator");
                Console.WriteLine("4 - Cartesian Plane");
                Console.WriteLine("5 - Exit");
                string userResponse = Console.ReadLine();

                // Conditional Questions
                if (userResponse == "1")
                {
                  
                    // basic calculator
                    Problem1();
                }
                // Loop Questions
                else if (userResponse == "2")
                { 
                    // finance calculator
                    Problem2();
                }
                else if (userResponse == "3")
                {
                    // Geometry calculator
                        Problem3();
                   
                }
                else if (userResponse == "4")
                {
                   // Cartesian plane
                        Problem4();
             
                }
                // Exit
                else if (userResponse == "5")
                {
                    Console.WriteLine("Thank you and have a good day.");
                    isRunning = false; // this sets the while loop to false resulting in the program ending
                }
                else
                {
                    Console.WriteLine("Please enter a valid option");
                }

            } while (isRunning);
            // Menu decision structure
        } // end of menu 




    } // End of class
}// End of namespace
