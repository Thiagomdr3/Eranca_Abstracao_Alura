using Eranca_Abstracao.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eranca_Abstracao.Sistema
{
    public interface IAutenticavel
    {
        public bool Autenticar(string senha);
        public void Inserir(int tipo);
    }
}
