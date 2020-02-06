using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaPolimorfismo.Entities.Pessoa
{
    class PessoaJuridica:Pessoa
    {
        public int QuantFun { get; set; }
        public PessoaJuridica(string nome, double rendaAnual, int quantFun) : base(nome, rendaAnual)
        {
            QuantFun = quantFun;
        }
        public override double CalculaImposto()
        {
            if (QuantFun > 10)
            {
                return (RendaAnual * 0.14);
            }
            else
            {
                return (RendaAnual * 0.16);
            }

        }

  
    }
}
