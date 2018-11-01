using Entities.buildinfiles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Entities.buildinfiles
{
    [Table("Appartments")]
    public class Appartment : Building
    {
        public Appartment(string Cat, Adress Adress, string AppartFloor, string Type) :
            base(Cat, Adress)
        {
            this.AppartFloor = AppartFloor;
            this.Type = Type;
        }

        private Appartment()
        {

        }
        public string AppartFloor { get; set; }
        public string Type { get; set; }

        //For presenting the Appartment
        public override string ToString()
        {
            return base.ToString() + " " + Type + " on floor number: "  + AppartFloor + " " + Adress.ToString();
        }

    }
}
