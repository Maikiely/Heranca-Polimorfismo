using System;
using System.Collections.Generic;
using System.Text;
using HerancaPolimorfismo.Entities.Shape.Enuns;

namespace HerancaPolimorfismo.Entities.Shape
{
    class Circle : Shape
    {
        public double Radios { get; set; }

        public Circle(double radios, Color color) : base(color)
        {
            Radios = radios;
        }

        public override double Area()
        {
            return MathF.PI * Radios * Radios;
        }
    }
}
