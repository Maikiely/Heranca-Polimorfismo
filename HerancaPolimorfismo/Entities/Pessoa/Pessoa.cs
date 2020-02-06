using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using HerancaPolimorfismo.Entities.Pessoa;

namespace HerancaPolimorfismo.Entities.Pessoa
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Pessoa(string name, double rendaAnual)
        {
            Nome = name;
            RendaAnual = rendaAnual;
        }

        public abstract double CalculaImposto();

        public override string ToString()
        {
            return Nome + ": $ " + CalculaImposto().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
