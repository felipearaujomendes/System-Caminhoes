using System;
using System.Collections.Generic;
using System.Text;

namespace caminhoes.Domain.Entities
{
    public class Caminhao:Entity
    {
        public string Modelo { get; set; }
        public string AnoModelo { get; set; }
        public string AnoFabricacao { get; set; }
    }
}
