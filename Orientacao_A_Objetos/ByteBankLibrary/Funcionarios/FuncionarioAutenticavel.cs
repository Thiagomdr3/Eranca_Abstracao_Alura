using ByteBankLibrary.Sistema;
using Eranca_Abstracao.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eranca_Abstracao.Funcionarios
{
    public abstract class FuncionarioAutenticavel:Funcionario,IAutenticavel
    {
        AutenticacaoHellper autenticacaoHellper = new();
        public string Senha { get; set; }

        public FuncionarioAutenticavel(string tipo, double salario):base(tipo, salario){ }

        public bool Autenticar(string senha)
        {
            return autenticacaoHellper.CompararSenhas(this.Senha, senha);
        }

        public void Inserir(int tipo)
        {
            switch (tipo)
            {
                case (((int)Tipo.Coordenador)):
                    Coordenador coordenador = new();
                    CadastrarFuncionario(coordenador);
                    break;
                case (((int)Tipo.Diretor)):
                    Diretor diretor = new();
                    CadastrarFuncionario(diretor);
                    break;
                default:
                    break;
            }
        }

        public void CadastrarFuncionario(Funcionario funcionario)
        {
            Console.WriteLine($"Insira o nome do {funcionario._tipo}");
            funcionario.nome = Console.ReadLine();
            Console.WriteLine($"Insira o cpf do {funcionario._tipo} {funcionario.nome}");
            funcionario.cpf = Console.ReadLine();
            funcionario.dataContratacao = DateTime.Now;

            Console.WriteLine($"tipo {funcionario._tipo}");
            Console.WriteLine($"nome {funcionario.nome}");
            Console.WriteLine($"cpf {funcionario.cpf}");
            Console.WriteLine($"salario {funcionario._salario}");
            Console.WriteLine($"Data contratação {funcionario.dataContratacao}");
        }

        public enum Tipo
        {
            Coordenador = 2,
            Diretor = 3,
        }
    }
}
