using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraIR.Services.Interfaces;

namespace CalculadoraIR.Services
{
    public class TaxCalculation : ITaxCalculator
    {
        readonly IAliquotCalculator _aliquot;
        readonly IDeductionCalculation _deduction;

        public TaxCalculation(IAliquotCalculator aliquotCalculator, IDeductionCalculation deductionCalculator)
        {
            _aliquot = aliquotCalculator;
            _deduction = deductionCalculator;
        }
        public double Tax { get; set; }
        public double TaxCalculator(double value) 
        {
            //Calcular o valor de imposto a ser pago
            Tax = (value * _aliquot.AliquotCalculator(value)) - _deduction.DeductionCalculation(value);
            return Tax;
        }
    }
}
