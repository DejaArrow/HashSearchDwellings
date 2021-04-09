using System;

namespace HashSearchDwellings
{
    class AddDwelling
    {
        Dwelling dwelling = new Dwelling (DwellingType, Identifier, PostCode, HouseholderName, Residents, SingleFloored);

        public void InputDetails()
        { 
            Console.WriteLine("---Add New Dwelling---");
            Console.WriteLine("Select Dwelling Type: ");
            Console.WriteLine("1) House");
            Console.WriteLine("2) Flat");
            Console.WriteLine("3) Bungalow");
            string DwellingType = Console.ReadLine();

            try
            {
                switch (DwellingType)
                {
                    case 1 : DwellingType = "House";
                    Console.WriteLine = "You selected House.";
                    break;
                    case 2 : DwellingType = "Flat";
                    Console.WriteLine = "You selected Flat.";
                    break;
                    case 3 : DwellingType = "Bungalow";
                    Console.WriteLine = "You selected Bungalow.";
                    break;
                    
                    
                }
            } catch (ArgumentOutOfRangeException e) 
                {
                    Console.WriteLine("Invalid Option");
                }  
            
            Console.WriteLine("Enter Dwelling Identifier: ");
            Identifier = Console.ReadLine();

            Console.WriteLine("Enter Dwelling PostCode: ");
            PostCode = Console.ReadLine();

            Console.WriteLine("Enter HouseHolder Name: ")
            HouseholderName = Console.ReadLine();

            Console.WriteLine("Enter number of Residents: ")
            Residents = Console.ReadLine();

            Console.WriteLine("Is it single floored? Y/N ")
            Console.ReadLine(input)
            input == "Y" ? SingleFloored = true : SingleFloored = False;

            DwellingTable.Add(dwelling.GetHashCode(), dwelling);
                



        }
    }
}