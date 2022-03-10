using caminhoes.Application.Validations;
using caminhoes.Domain.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace caminhoes.Application.Commands
{
    public class CaminhaoCommand : Command
    {
        public string Modelo { get; set; }
        public string AnoFabricacao { get; set; }
        public string AnoModelo { get; set; }
        public override bool EhValido()
        {
            ValidationResult = new CaminhaoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
