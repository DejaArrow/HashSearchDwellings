using System;
using System.Collections;

namespace HashSearchDwelling
{
    public static class DwellingTable
    {
        public static Hashtable table = new Hashtable();

        private static object _lockThis = new object();

        public static void AddDwelling(Dwelling dwelling)
        {
            lock (_lockThis)
            {
                table.Add(dwelling.GetHashCode(), dwelling);
            }
        }



    }
}