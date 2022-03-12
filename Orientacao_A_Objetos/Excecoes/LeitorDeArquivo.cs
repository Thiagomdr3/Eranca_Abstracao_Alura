using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
    public class LeitorDeArquivo:IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;
            //throw new FileNotFoundException("Arquivo nao encontrado");
            Console.WriteLine($"Abrindo arquivo: {arquivo}");
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo Linha... ");
            throw new IOException("Problema ao ler o arquivo");
            return "Linha do arquivo";
        }

        //public void Fechar()
        //{
        //}

        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo");
        }
    }
}
