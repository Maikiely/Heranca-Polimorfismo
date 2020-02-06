using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaPolimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; }
        
        public UsedProduct(string name, double price, DateTime manufactureDate): base(name, price)
        {
            this.manufactureDate = manufactureDate;
        }

        public override string Tag()
        {
            return Name + " (Used) $" + price + " (Manufacture date: " + manufactureDate.ToShortDateString() + ") " ;
        }


    }
}
