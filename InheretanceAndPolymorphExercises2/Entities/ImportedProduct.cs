using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceAndPolymorphExercises2.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {  
            CustomFee = customFee;
        }

        public double totalPrice()
        {
            return Price + CustomFee;
        }

        public override string priceTag()
        {
            return Name + ", $" +   Price +  "(" + "Custom Fee: " + CustomFee + ")";
        }
    }
}
