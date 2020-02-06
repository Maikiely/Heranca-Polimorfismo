using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaPolimorfismo.Entities.Pessoa
{
    class PessoaFisica : Pessoa
    {
        public double GastoSaude { get; set; }

        public PessoaFisica(string nome,double rendaAnual,double gastoSaude):base(nome,rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double CalculaImposto()
        {
            if (RendaAnual < 20000)
            {
                return (RendaAnual * 0.15) - (GastoSaude * 0.50);
            }
            else
            {
                return (RendaAnual * 0.25) - (GastoSaude * 0.50);
            }
            
        }

    }
}
