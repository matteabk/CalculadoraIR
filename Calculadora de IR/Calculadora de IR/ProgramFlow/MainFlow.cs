using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_IR
{
    public class MainFlow : IMainFlow
    {
        private readonly IScreenPresentation _presentation;
        private readonly IRegisterInput _registerInput;

        public MainFlow(
            IScreenPresentation presentation,
            IRegisterInput registerInput)
        {
            _presentation = presentation;
            _registerInput = registerInput;

        }
        public void StartApp()
        {
            _presentation.AskInput();
            _presentation.ShowTax(_registerInput.ReceiveInput());
        }
    }
}
