using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaPolimorfismo.Entities
{
    class OutsourcedEmployee: Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string nome, int hours, double valuePerHours, double additionalCharge): base(nome, hours, valuePerHours)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            
            return base.Payment() + 1.1 * AdditionalCharge;
        }


    }
}
