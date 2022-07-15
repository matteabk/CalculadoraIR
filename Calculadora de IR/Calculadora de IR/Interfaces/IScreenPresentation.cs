using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_IR
{
    public interface IScreenPresentation
    {
        public void AskInput();
        public void ShowTax(double value);
    }
}
