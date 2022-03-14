using Eranca_Abstracao.Interfaces;
using Eranca_Abstracao.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eranca_Abstracao.Funcionarios
{
    public class Coordenador:FuncionarioAutenticavel,ICoordenador
    {
        public Coordenador() : base("Coordenador", 4000) { }

        public override string Ferias => base.Ferias;

        public override void AumentarSalario()
        {
            _salario *= 1.25;
        }

        public override double GetBonificacao()
        {
            return _salario * 1.1;
        }
    }
}
