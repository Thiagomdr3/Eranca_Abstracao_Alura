using Eranca_Abstracao.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eranca_Abstracao.Sistema
{
    public class SistemaInterno
    {
        public bool Logar(Diretor diretor, string senha)
        {
            bool usuarioAutenticado = diretor.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine($"Bem vindo {diretor.nome}!");
                return true;
            }
            else
            {
                Console.WriteLine($"Usuario ou senha inválido!");
                return false;
            }
        }
    }
}
