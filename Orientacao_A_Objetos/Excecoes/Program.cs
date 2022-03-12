using Excecoes.Erros;
using System;
using System.IO;

namespace Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LerArquivos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void LerArquivos()
        {
            // using serve para fechar conecções com banco arquivos etc independente de casos que deem exceções ou nao
            using (LeitorDeArquivo leitor1 = new LeitorDeArquivo("arquivo.txt"))
            {
                leitor1.LerProximaLinha();
            }

            //LeitorDeArquivo leitor = null;

            //try
            //{
            //    leitor = new("contas.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch (IOException ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    //if (leitor != null)
            //    //leitor.Fechar();
            //}
        }

        private static void TestarInnerException()
        {
            //try
            //{
            //    ContaCorrente conta = new(357, 12345);
            //    Console.WriteLine($"{conta.Numero} {conta._agencia}");
            //    ContaCorrente conta2 = new(555, 897560);
            //    //ContaCorrente con = new(0, 0); //// Erro criação de conta

            //    conta2.Depositar(50);
            //    //conta.Sacar(500);   ////Erro saldo insuficiente
            //    //conta.Sacar(-500);   ////Erro saque negativo
            //    conta2.Transferir(250, conta);
            //}
            //catch (SaldoInsuficienteException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            try
            {
                ContaCorrente conta1 = new(123, 333);
                ContaCorrente conta2 = new(222, 4568);

                conta2.Depositar(100);
                conta2.Transferir(10000, conta1);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("##########\n Dados da exception oculta:");
                Console.WriteLine(e.InnerException.Message);
            }
        }
    }
}
