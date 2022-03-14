using Eranca_Abstracao.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eranca_Abstracao.Funcionarios
{
    public interface IDiretor
    {
        string Ferias { get; }

        void AumentarSalario();

        double GetBonificacao();

        void Inserir(int tipo);
    }
}
