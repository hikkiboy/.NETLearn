using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceAndPolymorphExercises2.Entities
{
    internal class UsedProduct : Product
    {
       public DateTime ManufacturedDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price , DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }
        public override string priceTag()
        {
            return Name + " (used) " + Price + "(" + "Manufactured: " + ManufacturedDate + ")";
        }
    }
}
