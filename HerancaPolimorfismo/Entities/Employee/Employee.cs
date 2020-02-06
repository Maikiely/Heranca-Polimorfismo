using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaPolimorfismo.Entities
{
    class Employee
    {
        public string Nome { get; set; }
        public int Hours { get; set; }
        public  double ValuePerHours { get; set; }
        public Employee()
        {

        }
        public Employee(string nome, int hours, double valuePerHours)
        {
            Nome = nome;
            Hours = hours;
            ValuePerHours = valuePerHours;
        }

        public virtual double Payment( )
        {
            return ValuePerHours * Hours;
        }


    }
}
