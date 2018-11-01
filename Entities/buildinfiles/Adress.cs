using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.buildinfiles

{
    [Serializable]
    public class Adress
    {
        //Getters and setters for all the properties of adress
        public string City { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }


        //Constructor 
        private Adress()
        {

        }

        public Adress(string City, string Street, string Zip, string Country)
        {
            this.City = City;
            this.Street = Street;
            this.Zip = Zip;
            this.Country = Country;

        }

        //For presenting the adress
        public override string ToString()
        {
            return "\n" + "With adress: " + "\n" + "Country: " + Country + "\n" + "City: " + City + "\n" + "ZipCode: " + Zip + "\n" + "Street: " + Street;
        }

    }
}
