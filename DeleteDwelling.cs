using System;
using System.Collections;

namespace HashSearchDwelling
{
    public static class DeleteDwelling
    {
        //Deletes dwelling from table. 
        public static void  DeleteDetails()
        {
            Console.WriteLine("---Delete a Dwelling---");
            Console.WriteLine("Type Postcode: ");
            string PostCode = Console.ReadLine();
            Console.WriteLine("Type Identifier: ");
            string Identifier = Console.ReadLine();

            int key = (PostCode + Identifier).GetHashCode();
           //Gets key

            if(DwellingTable.table.ContainsKey(key))
            {
                Console.WriteLine("Is this the dwelling you wish to delete? Y/N ");
                ((Dwelling)DwellingTable.table[key]).Display();
                string option = Console.ReadLine();
                option = option.ToUpper();
                if(option == "Y")
                {
                    DwellingTable.table.Remove(key);
                    //Deletes entry in table.
                }
               

                
            }
           else
           {
               
               Console.WriteLine("Dwelling not found.");
               
           }
        }
    }
}