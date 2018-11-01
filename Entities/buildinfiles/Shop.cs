using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Entities.buildinfiles
{
    [Table("Shops")]
    public class Shop : Building
    {
        public string NbrOfRegisters { get; set; }
        public string Type { get; set; }

        public Shop(string Cat, Adress Adress, string NbrOfRegisters, string Type) :
            base(Cat, Adress)
        {
            this.NbrOfRegisters = NbrOfRegisters;
            this.Type = Type;
        }
        private Shop()
        {

        }

        public override string ToString()
        {
            return base.ToString() + " " + Type + " Number of registers in shop; " + NbrOfRegisters + " " + Adress.ToString();
        }

    }
}
