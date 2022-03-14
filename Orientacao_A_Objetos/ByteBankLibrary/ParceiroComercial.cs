using ByteBankLibrary.Sistema;
using Eranca_Abstracao.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankLibrary
{
    public class ParceiroComercial:IAutenticavel
    {
        AutenticacaoHellper autenticacaoHellper = new();
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return autenticacaoHellper.CompararSenhas(this.Senha, senha);
        }

        public void Inserir(int tipo)
        {
            throw new NotImplementedException();
        }
    }
}
