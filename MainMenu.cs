using System;

namespace HashSearchDwelling
{
    public class MainMenu
    {
        public void MenuOptions()
        {
            Console.WriteLine("Choose an Option: ");
            Console.WriteLine("1) Search for a Dwelling.");
            Console.WriteLine("2) Add a new Dwelling.");
            Console.WriteLine("3) Delete an existing Dwelling.")
            Console.WriteLine("Please enter 1, 2 or 3: ")
            Console.ReadLine();
            
            try
            {
                switch (input)
                {
                    case 1 : SearchDwelling()
                    break;
                    case 2 : AddNewDwelling()
                    break;
                    case 3 : DeleteDwelling()
                    break;
                    
                    
                }
            } catch (ArgumentOutOfRangeException e) 
                {
                    Console.WriteLine("Invalid Option");
                }  
        }
        
    
    }

    
}