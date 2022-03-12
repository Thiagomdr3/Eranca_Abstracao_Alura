using Eranca_Abstracao.Funcionarios;
using Eranca_Abstracao.Interfaces;
using Eranca_Abstracao.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eranca_Abstracao
{
    public class Initial
    {
        private readonly IDiretor _diretor;
        private readonly ICoordenador _coordenador;

        public Initial(IDiretor diretor, ICoordenador coordenador)
        {
            _diretor = diretor;
            _coordenador = coordenador;
        }
        public void Start()
        {
            Tipo cargo = (Tipo)1;
            bool laco = true;

            while (laco)
            {
                Console.Clear();
                Console.WriteLine("Escolha um dos cargos abaixo:\n");
                foreach (var item in Enum.GetValues(typeof(Tipo)))
                {
                    Console.WriteLine($"\t{(int)item} - {item.ToString().Replace("_", " ")}\n");
                }

                try
                {
                    cargo = (Tipo)Enum.Parse(typeof(Tipo), Console.ReadLine());
                }
                catch (Exception)
                {
                    cargo = (Tipo)0;
                }

                switch (cargo)
                {
                    case Tipo.Auxiliar_de_escritório:
                        laco = false;
                        break;
                    case Tipo.Coordenador:
                        _coordenador.Inserir(((int)Tipo.Coordenador));
                        laco = false;
                        break;
                    case Tipo.Diretor:                        
                        _diretor.Inserir((int)Tipo.Diretor);
                        laco = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.\nPrecione qualquer tecla para continuar:");
                        Console.ReadKey();
                        break;
                }
            }
        }
        public void LogarSistema(Diretor diretor)
        {
            SistemaInterno sistema = new();
            sistema.Logar(diretor, "thg123");
            sistema.Logar(diretor, "123");
        }
        public enum Tipo
        {
            Auxiliar_de_escritório = 1,
            Coordenador = 2,
            Diretor = 3,
        }
    }
}
