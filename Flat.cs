using System;

namespace HashSearchDwellings
{
    class  Flat : IDwellingFactory
    {
        public string DwellingType { get; set; }
        public string PostCode { get; }
        public string Identifier { get; set; }
        public string HouseholderName { get; set; }
        public int Residents { get; set; }
        public bool SingleFloored { get { return true; } }
        public override int GetHashCode() => (PostCode + Identifier).GetHashCode();

        public Flat(string DwellingType, string postCode, string identifier)
        {
            DwellingType = "Flat";
            PostCode = postCode;
            Identifier = identifier;

        }

        
    }
}