using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eranca_Abstracao.Funcionarios
{
    public abstract class Funcionario
    {
        public static int _TotalFuncionarios { get; private set; }

        public string _tipo { get; protected set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public double _salario { get; protected set; }
        public DateTime dataContratacao { get; set; }

        public Funcionario(string tipo, double salario)
        {
            _tipo = tipo;
            _salario = salario;
            _TotalFuncionarios++;
        }

        public virtual string GetFerias()
        {
            DateTime vencimentoFerias = dataContratacao;
            vencimentoFerias.Subtract(DateTime.Now);
            return $"Faltam {vencimentoFerias.Month} meses para o vencimento das ferias do {_tipo} {nome}";
        }

        public virtual double GetBonificacao()
        {
            return _salario;
        }

        public abstract void AumentarSalario();
    }
}
