using System;

namespace HashSearchDwellings
{
    public interface IDwellingFactory
    {
        string DwellingType {get; }
        string PostCode { get; }
        string Identifier { get; }
        string HouseholderName { get; }
        int Residents { get; }
        bool SingleFloored { get; }
        int GetHashCode();

        public Dwelling(string DwellingType, string PostCode, string Identifier, string HouseholderName, int Residents, bool SingleFloored, int GetHashCode)
        {
          
          this.DwellingType = DwellingType;
          this.PostCode = PostCode;
          this.Identifier = Identifier;
          this.HouseholderName = HouseholderName;
          this.Residents = Residents;
          
        
        }

    }


}