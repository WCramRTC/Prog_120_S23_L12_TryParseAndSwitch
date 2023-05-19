namespace Prog_120_S23_L12_TryParseAndSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TryParseDemo();

        } // Main

        public static void TryParseDemo()
        {
            // Create a small menu
            // that displays 3 options
            // asks the user for their choice
            // and repeats if the users option is invalid

            // ***** Displayed our menu options
            Console.WriteLine("1 - Choice 1");
            Console.WriteLine("2 - Choice 2");
            Console.WriteLine("3 - Choice 3");
            Console.Write("Please Enter a valid choice: ");

            // ***** Took users choice and TRIED TO PARSE IT

            string usersChoiceFromMenu = Console.ReadLine();
            int usersConvertedNumber;
            bool tryToConvertUsersChoice = int.TryParse(usersChoiceFromMenu, out usersConvertedNumber);

            // Using the while loop as a gate, to prevent the user from going into the rest of our application
            // tryToConvert == false : Will loop everytime the user gives us an invalid number

            // ***** IF it fails, keep asking the user to enter a valid number

            // Our while will keep asking the user to enter a valid number
            while (tryToConvertUsersChoice == false)
            {
                Console.WriteLine("The user has entered an invalid number");
                Console.WriteLine(usersConvertedNumber);

                Console.Write("Please enter a valid number: ");
                // type.TryParse(Value To Parse, out Variable To Save To)
                //usersChoiceFromMenu = Console.ReadLine();
                tryToConvertUsersChoice = int.TryParse(Console.ReadLine(), out usersConvertedNumber);
            }
            // Only reach here after they have entered a valid number

            // ***** If a valid number, use a switch to respond to the users choice

            // IN THE REAL WORLD, ITS COMMON TO PASS IN STRINGS
            // Use a switch to respond to the users choice
            switch (usersConvertedNumber)
            {
                case 1:
                    Console.WriteLine("You have entered choice 1");
                    break;
                case 2:
                    Console.WriteLine("You have entered choice 2");
                    break;
                case 3:
                    Console.WriteLine("You have entered choice 3");
                    break;
                default:
                    Console.WriteLine("You have not chosen one of the options");
                    break;
            }
        }

        public static void SwitchExample()
        {
            //-------------------------------------------------
            // Switch
            // Keywords : Switch, Case, Break, Default

            // Start with switch and an argument
            Console.Write("C://");
            string userInput = Console.ReadLine();

            // Switch statements are great when you have multiple selections to choose from
            // Will only COMPARE two values
            switch (userInput)
            {
                // Case
                case "Benel":
                    Console.WriteLine("Hi Benel");
                    break;

                case "David":
                    Console.WriteLine("Hi David");
                    break; // Break is a keyword that breaks OUT of a code block

                case "Will":
                case "Menu":
                    // If (userInput == "Will" || userInput == "Menu") {}
                    Console.WriteLine("Hello Will");
                    TryParseDemo();
                    break;
                default: // Is Like Else
                    Console.WriteLine("That choice does not exist");
                    break;

            } // End of my switch

            // case 10:
            // case 11:
            // case 12:
            // case 13:
            // .
            // .
            // case 50:

            // if (userInput >= 10 && userInput <= 50) {}


            // If statements allow you to do a lot more with math and comparisons
            // More complex to write and read
            // Each code block is it's own scope
            if ("Will" == "Benel")
            {

                Console.WriteLine("Hi Benel");
            }
            else if ("Will" == "David")
            {

                Console.WriteLine("Hi David");
            }
            else if ("Will" == "WIll")
            {
                Console.WriteLine("Hello Will");
            }
        }

        public static void TryParseExampleCode()
        {
            // TryParse
            // TryCatch should only be used for catastrophic failures

            int normalParseExample = int.Parse("6");

            // type.TryParse(Value To Parse, out Variable To Save To)

            // Out is a uniqe keyword that allows us to have a second type of return type

            int convertedNumber;
            // If true, the converted number is saved to the out variable
            // if FALSE, the out variable returns 0
            bool isNumberValid = int.TryParse("David", out convertedNumber);

            //Console.WriteLine("This isNumberValid variable is " + isNumberValid);

            if (isNumberValid)
            {
                Console.WriteLine("Your number was valid");
                Console.WriteLine("The number that you passed in is " + convertedNumber);
                Console.WriteLine(convertedNumber * convertedNumber);
            }
            else
            {
                Console.WriteLine("Your number was invalid");
                Console.WriteLine("The number that you passed in is " + convertedNumber);
            }


            // inputs
            // outputs

            // variables
            // operations

            // loops <-
            // conditions <-

            // Resolve - Result of an operation
            if (true)
            {
                // This will run because the argument is true
            }

            while (true)
            {
                // This will run infinetly because the argument is true
            }

        }

        public static void TryCatchExampleCode()
        {
            // Created a string to hold "25"
            string number25 = "25";
            // Created an int and parsed "25" into a number
            int convertedStringToNumber25 = int.Parse(number25);

            // If the information passed in is WRONG it would crash
            //string stringWithInvalidNumber = Console.ReadLine();
            //int covertingInvalidNumber = int.Parse(stringWithInvalidNumber);

            // Try Catch 
            // Code block, meant to respond to Exceptions that are thrown
            // When our code does not work properly

            try // We TRY to run code, that has the potential to crash
            {
                Console.WriteLine("Demonstrating Try Catch");
                int.Parse("twenty Five");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a valid number. " + ex.Message);
            }

        }

    } // class

} // namespace