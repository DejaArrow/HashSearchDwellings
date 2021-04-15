using System;
using System.Collections;

namespace HashSearchDwelling
{
    public static class DeleteDwelling
    {
        public static void  DeleteDetails()
        {
            Console.WriteLine("---Delete a Dwelling---");
            Console.WriteLine("Type Postcode: ");
            string PostCode = Console.ReadLine();
            Console.WriteLine("Type Identifier: ");
            string Identifier = Console.ReadLine();

            int key = (PostCode + Identifier).GetHashCode();
           

            if(DwellingTable.table.ContainsKey(key))
            {
                Console.WriteLine("Is this the dwelling you wish to delete? Y/N ");
                ((Dwelling)DwellingTable.table[key]).Display();
                string option = Console.ReadLine();
                option = option.ToUpper();
                if(option == "Y")
                {
                    DwellingTable.table.Remove(key);
                }
               

                
            }
           else
           {
               
               Console.WriteLine("Dwelling not found.");
               
           }
        }
    }
}