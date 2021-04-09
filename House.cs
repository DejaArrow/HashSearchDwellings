using System;

namespace HashSearchDwellings
{
    class House : IDwellingFactory
    {
        public string DwellingType { get; set; }
        public string PostCode { get; }
        public string Identifier { get; set; }
        public string HouseholderName { get; set; }
        public int Residents { get; set; }
        public bool SingleFloored { get { return false; } }
        public override int GetHashCode() => (PostCode + Identifier).GetHashCode();

        public House(string DwellingType, string postCode, string identifier)
        {
            DwellingType = "House";
            PostCode = postCode;
            Identifier = identifier;

        }
    }
}