using System;
using System.Collections;


namespace HashSearchDwelling 
{
    public static class SearchDwelling  
    {
        public static void SearchDetails()
        {
        //searches table for dwellings.
        
            Console.WriteLine("---Search for Dwelling ");
            Console.WriteLine("Type Postcode: ");
            string PostCode = Console.ReadLine();
            Console.WriteLine("Type Identifier: ");
            string Identifier = Console.ReadLine();

            int key = (PostCode + Identifier).GetHashCode();
           //turns user input into a searchable code.

            if(DwellingTable.table.ContainsKey(key))
            {
                ((Dwelling)DwellingTable.table[key]).Display();
               //Displays the dwelling info attacked to the key.
                

                
            }
           else
           {
               
               Console.WriteLine("Dwelling not found.");
               
           }
        }
    }
}