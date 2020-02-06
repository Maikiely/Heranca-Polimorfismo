using System;
using System.Collections.Generic;
using System.Text;
using HerancaPolimorfismo.Entities.Shape.Enuns;


namespace HerancaPolimorfismo.Entities.Shape
{
     abstract class Shape
     {
        public Color Color { get; set; }
        
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
