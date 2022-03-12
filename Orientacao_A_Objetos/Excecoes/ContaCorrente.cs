// using _05_ByteBank;

using Excecoes.Erros;
using System;

namespace Excecoes
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }
        public int TentativasDeSaquesInsuficientes { get; private set; }
        public int TentativasDeTransferenciasInsuficientes { get; private set; }



        public readonly int _agencia;

        public int Numero { get; }

        private double _saldo;

        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0 || numero <= 0)
            {
                throw new ArgumentException("Conta e agencia tem que ser maiores que 0", nameof(numero));
            }
            _agencia = agencia;
            Numero = numero;

            //TaxaOperacao = 30 / TotalDeContasCriadas;

            TotalDeContasCriadas++;
        }


        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                TentativasDeSaquesInsuficientes++;
                throw new ArgumentException("Não é possível realizar saques de valor negativo", nameof(valor));
            }
            if (_saldo < valor)
            {
                //throw new SaldoInsuficienteException($"Saldo insuficiente pra o valor de {valor}");
                throw new SaldoInsuficienteException($"Tentativa de saque: Valor = {valor} Saldo = {_saldo}");
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            //if (_saldo < valor)
            //{
            //    throw new SaldoInsuficienteException("Saldo insuficiente: Saldo = ", _saldo);
            //}
            try
            {
                Sacar(valor);
            }
            catch(SaldoInsuficienteException ex)
            {
                TentativasDeTransferenciasInsuficientes++;
                throw new OperacaoFinanceiraException("Operação não realizada", ex);

            }
            contaDestino.Depositar(valor);
            return true;
        }
        //public void ValidarValor(double valor)
        //{

        //}
    }
}
