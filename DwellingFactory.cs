using System;
using System.Collections;

namespace HashSearchDwelling
{
  public class DwellingFactory
  {  
    //Builds dwelling types.
    public Dwelling CreateDwelling(string type, string PostCode, string Identifier, string HouseholderName, int Residents)
    {
      type = type.ToLower();

            switch (type)
            {
                case "bungalow" : 
                return new Bungalow( PostCode, Identifier,  HouseholderName, Residents);

                case "house" : 
                return new House( PostCode, Identifier,  HouseholderName, Residents);

                case "flat" : 
                return new Flat( PostCode, Identifier,  HouseholderName, Residents);

                default :
                Console.WriteLine ("Invalid type");
                return null;
                
                
            }
    }
    
    
  }
    public abstract class Dwelling 
    {
        
        public string PostCode { get; }
        public string Identifier { get; }
        public string HouseholderName { get; }
        public int Residents { get; }
        protected bool SingleFloored { get; }

        public override int GetHashCode() => (PostCode + Identifier).GetHashCode();
        
        protected string DwellingType { get; }

            

        public Dwelling(string dwellingType, bool singleFloored, string PostCode, string Identifier, string HouseholderName, int Residents)
        {
          
          this.DwellingType = dwellingType;
          this.SingleFloored = singleFloored;
          this.PostCode = PostCode;
          this.Identifier = Identifier;
          this.HouseholderName = HouseholderName;
          this.Residents = Residents;

               
        
        }

        public void Display ()
        {//Displays Dwelling information.
          
          Console.WriteLine($"Type: {this.DwellingType}");
          Console.WriteLine($"Postcode: {this.PostCode}");
          Console.WriteLine($"Identifier: {this.Identifier}");
          Console.WriteLine($"Householder Name: {this.HouseholderName}");
          Console.WriteLine($"Residents: {this.Residents}");
          Console.WriteLine($"Single Floored: {this.SingleFloored}");
    
        }
        

    }

    public class Bungalow : Dwelling
    {
        public Bungalow(string PostCode, string Identifier, string HouseholderName, int Residents) : base ("Bungalow", true, PostCode, Identifier, HouseholderName, Residents)
        {
          
        }
    }

    public class House : Dwelling
    {
        public House(string PostCode, string Identifier, string HouseholderName, int Residents) : base ("House", false, PostCode, Identifier, HouseholderName, Residents)
        {
          
        }
    }

    public class Flat : Dwelling
    {
        public Flat(string PostCode, string Identifier, string HouseholderName, int Residents) : base ("Flat", true, PostCode, Identifier, HouseholderName, Residents)
        {
          
        }
    }


}