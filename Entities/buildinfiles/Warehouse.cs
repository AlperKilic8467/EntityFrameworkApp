using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Entities.buildinfiles
{
    [Table("Warehouses")]
    public class Warehouse : Building
    {
        public string Height { get; set; }
        public string Type { get; set; }

        public Warehouse(string Cat, Adress Adress, string Height, string Type) :
            base(Cat, Adress)
        {
            this.Height = Height;
            this.Type = Type;
        }
        private Warehouse()
        {

        }

        public override string ToString()
        {
            return base.ToString() + " " + Type + " Height of warehouse: " + Height + " " + Adress.ToString();
        }

    }
}
