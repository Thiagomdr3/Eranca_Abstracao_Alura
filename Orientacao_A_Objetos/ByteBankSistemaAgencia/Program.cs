using Eranca_Abstracao.Funcionarios;
using Excecoes;
using System;

namespace ByteBankSistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new(347, 555);

            conta.Depositar(150);
            Diretor dir = new();
            dir.Autenticar("");

            
        }
    }
}
