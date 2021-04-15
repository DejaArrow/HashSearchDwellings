using System;
using System.Collections;


namespace HashSearchDwelling
{
    public class MainMenu
    {
        public void MenuOptions()
        {
            int input;
            string option = "";

            do
            {
                Console.Clear();
                Console.WriteLine("Choose an Option: ");
                Console.WriteLine("1) Search for a Dwelling.");
                Console.WriteLine("2) Add a new Dwelling.");
                Console.WriteLine("3) Delete an existing Dwelling.");
                Console.WriteLine("Please enter 1, 2 or 3: ");
                input = int.Parse(Console.ReadLine());
                //Gives user an option to choose.
                try
                {
                    switch (input)
                    {
                        case 1:
                            SearchDwelling.SearchDetails();
                            break;
                        case 2:
                            AddDwelling.InputDetails();
                        break;
                        case 3:
                            DeleteDwelling.DeleteDetails();
                            break;

                            


                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Invalid Option");
                }

                Console.WriteLine("Would you like to go back to the Menu? Y/N");
                option = Console.ReadLine();
                option = option.ToUpper();
                //Sends user back to main menu.

            }
            while (option != "N");
            //Loops until user enters 'n' and exits the program

        }


    }


}