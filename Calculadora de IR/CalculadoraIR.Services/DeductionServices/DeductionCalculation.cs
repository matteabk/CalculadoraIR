using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraIR.Services.Interfaces;

namespace CalculadoraIR.Services
{
    public class DeductionCalculation : IDeductionCalculation
    {

        double IDeductionCalculation.DeductionCalculation(double value)
        {
            double deduction = 0;

            if (value >= 22847.77 && value < 33919.81)
            {
                deduction = 1713.85;
            }
            else if (value >= 33919.81 && value < 45012.61)
            {
                deduction = 4257.57;
            }
            else if (value >= 45012.61 && value < 55976.17)
            {
                deduction = 7633.51;
            }
            else if (value >= 55976.17)
            {
                deduction = 10432.32;
            }

            return deduction;
        }
    }
}
