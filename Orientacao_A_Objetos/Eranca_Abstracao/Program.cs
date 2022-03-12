using Eranca_Abstracao.Funcionarios;
using Eranca_Abstracao.Interfaces;
using Eranca_Abstracao.Sistema;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Eranca_Abstracao
{
    class Program
    {
        static void Main()
        {
            var services = new ServiceCollection();
            services
                .AddScoped<IDiretor, Diretor>()
                .AddScoped<ICoordenador, Coordenador>()
                .AddScoped<Initial, Initial>();

            var serviceProvider = services.BuildServiceProvider();
            var instance = serviceProvider.GetService<Initial>();
            instance.Start();
        }
    }
}
