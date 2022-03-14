using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eranca_Abstracao.Funcionarios
{
    public class AuxiliarEscritorio:Funcionario
    {
        public AuxiliarEscritorio() : base("Auxiliar de escritório", 2000) { }

        public override string Ferias => base.Ferias;

        public override void AumentarSalario()
        {
            _salario *= 1.1;
        }

        public override double GetBonificacao()
        {
            return base.GetBonificacao();
        }
    }
}
