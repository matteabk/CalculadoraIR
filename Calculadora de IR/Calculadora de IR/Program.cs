using System;
using CalculadoraIR.Services;
using CalculadoraIR.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Calculadora_de_IR
{
    public class Program
    {
        public static void Main()
        {
            ServiceCollection services = new();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();
            var mainFlow = serviceProvider.GetService<IMainFlow>();

            mainFlow.StartApp();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<IMainFlow, MainFlow>()
                .AddScoped<IScreenPresentation, ScreenPresentation>()
                .AddScoped<IRegisterInput, RegisterInput>()
                .AddScoped<ITaxCalculator, TaxCalculation>()
                .AddScoped<IDeductionCalculation, DeductionCalculation>()
                .AddScoped<IAliquotCalculator, AliquotCalculator>();
        }
    }
}
