using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraIR.Services.Interfaces;

namespace Calculadora_de_IR
{

    public class ScreenPresentation : IScreenPresentation
    {
        private readonly ITaxCalculator _taxCalculator;

        public ScreenPresentation(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }
        public void AskInput()
        {
            Console.WriteLine("Digite o seu salário anual em reais (R$):");
        }

        public void ShowTax(double value)
        {
            Console.WriteLine($"O valor a ser pago de imposto é de: R$ {Math.Round(_taxCalculator.TaxCalculator(value), 2)}");
        }
    }

}
