using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes.Erros
{
    public class SaldoInsuficienteException: OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double Valor { get; }
        public string Mensagem { get; }
        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }

        public SaldoInsuficienteException(double valor, double saldo)
            :this ($"Tentativa de saque no valor de {valor} em um saldo de {saldo}")
        {
            Valor = valor;
            Saldo = saldo;
        }

        public SaldoInsuficienteException(string mensagem, double valor, double saldo)
        {
            Mensagem = mensagem;
            Valor = valor;
            Saldo = saldo;
        }
        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna):base(mensagem, excecaoInterna)
        {

        }
    }
}
