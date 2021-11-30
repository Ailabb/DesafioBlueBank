using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Responses
{
   public class GetContaByIdResponse
    {
        public decimal Saldo { get; set; }
        public Guid ClienteId { get; set; }
        public int NumeroConta { get; set; }
        public int DigitoConta { get; set; }
        public int Agencia { get; set; }
    }
}
