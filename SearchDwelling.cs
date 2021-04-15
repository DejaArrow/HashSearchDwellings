using System;
using System.Collections;


namespace HashSearchDwelling 
{
    public static class SearchDwelling  
    {
        public static void SearchDetails()
        {
            Console.WriteLine("---Search for Dwelling ");
            Console.WriteLine("Type Postcode: ");
            string PostCode = Console.ReadLine();
            Console.WriteLine("Type Identifier: ");
            string Identifier = Console.ReadLine();

            int key = (PostCode + Identifier).GetHashCode();
           

            if(DwellingTable.table.ContainsKey(key))
            {
                ((Dwelling)DwellingTable.table[key]).Display();
               
                //If yes, SearchDetails(). If no, MainMenu();

                
            }
           else
           {
               
               Console.WriteLine("Dwelling not found.");
               
           }
        }
    }
}