// using _05_ByteBank;

using Excecoes.Erros;
using System;

namespace Excecoes
{
    /// <summary>
    /// Define uma Conta Corrente do banco ByteBank
    /// </summary>
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }
        public int TentativasDeSaquesInsuficientes { get; private set; }
        public int TentativasDeTransferenciasInsuficientes { get; private set; }



        public readonly int _agencia;

        public int Numero { get; }

        public double Saldo { get; private set; }
        /// <summary>
        /// Cria a instância de ContaCorrente com os argumentos utilizados.
        /// </summary>
        /// <param name="agencia"> Reresenta o valor da propriedade <see cref="_agencia"/> e deve possuir um valor maior que 0</param>
        /// <param name="numero"> Reresenta o valor da propriedade <see cref="Numero"/> e deve possuir um valor maior que 0</param>

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

        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Saldo"/>
        /// </summary>
        /// <exception cref="ArgumentException"> Exceção lançada quando um valor negativo é utilizado em <paramref name="valor"/>.</exception>
        /// <exception cref="SaldoInsuficienteException"> Exceçaõ lançada quando a propriedade <see cref="Saldo"/> é inferior ao parâmetro <paramref name="valor"/></exception>
        /// <param name="valor"> Representa o valor do saque, deve ser maior que 0 e menor que..</param>
        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                TentativasDeSaquesInsuficientes++;
                throw new ArgumentException("Não é possível realizar saques de valor negativo", nameof(valor));
            }
            if (Saldo < valor)
            {
                //throw new SaldoInsuficienteException($"Saldo insuficiente pra o valor de {valor}");
                throw new SaldoInsuficienteException($"Tentativa de saque: Valor = {valor} Saldo = {Saldo}");
            }

            Saldo -= valor;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
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
