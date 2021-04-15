using System;
using System.Collections;

namespace HashSearchDwelling
{
    
    public static class AddDwelling
    {        
        static DwellingFactory dwellingFactory = new DwellingFactory();
        public static void InputDetails()
        { 
            Console.WriteLine("---Add New Dwelling---");
            Console.WriteLine("Select Dwelling Type: ");
            Console.WriteLine("1) House");
            Console.WriteLine("2) Flat");
            Console.WriteLine("3) Bungalow");
            int DwellingType = int.Parse(Console.ReadLine());

            if (DwellingType == 1 || DwellingType == 2 || DwellingType == 3)
            {
                Console.WriteLine("Enter Dwelling Identifier: ");
                string Identifier = Console.ReadLine();

                Console.WriteLine("Enter Dwelling PostCode: ");
                string PostCode = Console.ReadLine();

                Console.WriteLine("Enter HouseHolder Name: ");
                string HouseholderName = Console.ReadLine();

                Console.WriteLine("Enter number of Residents: ");
                int Residents = int.Parse(Console.ReadLine());

                try
                {

                    switch (DwellingType)
                    {
                        case 1:

                            Console.WriteLine("Adding House.");
                            DwellingTable.AddDwelling(dwellingFactory.CreateDwelling("House",PostCode, Identifier, HouseholderName, Residents));
                            break;

                        case 2:

                            Console.WriteLine("Adding Flat.");
                            DwellingTable.AddDwelling(dwellingFactory.CreateDwelling("Flat",PostCode, Identifier, HouseholderName, Residents));
                            break;

                        case 3:
                            Console.WriteLine("Adding Bungalow.");
                            DwellingTable.AddDwelling(dwellingFactory.CreateDwelling("Bungalow",PostCode, Identifier, HouseholderName, Residents));
                            break;

                        default:
                            Console.WriteLine("Invalid dwelling type");
                            break;

                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Invalid Option");
                }

            }
        
                
          


        }
    }
}