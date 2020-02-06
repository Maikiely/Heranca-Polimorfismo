using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaPolimorfismo.Entities
{
    class ImportededProduct  : Product
    {
        public double customsFee { get; set; }
       
        public ImportededProduct(string name, double price, double customsFee): base(name,price)
        {
            this.customsFee = customsFee;
        }

        public double TotalValue()
        {
            return price + customsFee;
        }

        public override string Tag()
        {
            return Name +" $ "+ TotalValue() + $"(Customs Fee: {customsFee})";
        }

    }
}
