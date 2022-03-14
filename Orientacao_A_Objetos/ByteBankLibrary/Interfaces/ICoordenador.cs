﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eranca_Abstracao.Interfaces
{
    public interface ICoordenador
    {
        string Ferias { get; }

        void AumentarSalario();
        double GetBonificacao();
        void Inserir(int tipo);
    }
}
