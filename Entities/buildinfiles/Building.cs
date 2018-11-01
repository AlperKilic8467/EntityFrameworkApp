using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.buildinfiles
{
    [Serializable]
    public abstract class Building : IBuilding
    {
        //Getters and setters for properies of Building
        // private static int IDcount = 0;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BuildingID { get; set; }
        public string Cat { get; set; }
        public Adress Adress { get; set; }
       // public string Type { get; set; }

        //Constructor
        protected Building()
        {

        }

        public Building(string Cat, Adress Adress)
        {
          //  IDcount++;
            this.BuildingID = BuildingID;
            this.Cat = Cat;
           // this.Type = Type;
            this.Adress = Adress;
        }
        //For presenting the building
        public override string ToString()
        {
            return Cat ;
        }
    }
}
