using System;
using System.Collections;

namespace HashSearchDwelling
{
    public static class DwellingTable
    {
        
        public static Hashtable table = new Hashtable();
        //Creates new hash table.

        private static object _lockThis = new object();
        //Locks table to prevent more than one instance accessing it. 
        public static void AddDwelling(Dwelling dwelling)
        {
            lock (_lockThis)
            {
                table.Add(dwelling.GetHashCode(), dwelling);
            }
        }



    }
}