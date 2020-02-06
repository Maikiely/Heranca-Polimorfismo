using System;
using System.Collections.Generic;
using System.Text;
using HerancaPolimorfismo.Entities.Shape.Enuns;

namespace HerancaPolimorfismo.Entities.Shape
{
    class Retangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Retangle(double width,double height ,Color color):base (color) 
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
