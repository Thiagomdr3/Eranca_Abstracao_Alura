﻿using Eranca_Abstracao.Interfaces;
using Eranca_Abstracao.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eranca_Abstracao.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel, IDiretor
    {
        public Diretor() : base("Diretor", 7000) { }

        public override string Ferias => base.Ferias;

        public override void AumentarSalario() => _salario *= 1.4;

        public override double GetBonificacao() => _salario *= 1.5;
    }
}
