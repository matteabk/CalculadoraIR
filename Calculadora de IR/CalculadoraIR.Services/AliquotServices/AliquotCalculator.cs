using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraIR.Services.Interfaces;

namespace CalculadoraIR.Services
{
    public class AliquotCalculator : IAliquotCalculator
    {
        double IAliquotCalculator.AliquotCalculator(double value)
        {
            double aliquot = 0;

            if (value >= 22847.77 && value < 33919.81)
            {
                aliquot = 0.075;
            }
            else if (value >= 33919.81 && value < 45012.61)
            {
                aliquot = 0.15;
            }
            else if (value >= 45012.61 && value < 55976.17)
            {
                aliquot = 0.225;
            }
            else if (value >= 55976.17)
            {
                aliquot = 0.275;
            }

            return aliquot;
        }
    }
}
