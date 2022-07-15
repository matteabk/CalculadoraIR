using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_IR
{
    public class RegisterInput : IRegisterInput
    {
        public double ReceiveInput()
        {
            var input = Console.ReadLine();

            if (!ValidateInput(input))
            {
                Console.WriteLine("Valor digitado não é válido. Por favor digite novamente:");
                return ReceiveInput();
            }

            return Convert.ToDouble(input);
        }

        public bool ValidateInput(string input)
        {
            return (double.TryParse(input, out _) && Convert.ToDouble(input) >= 0);
        }
    }
}
