using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Requests
{
    public class AddClienteRequest
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public int NumeroConta { get; set; }
        public int DigitoConta { get; set; }
        public int Agencia { get; set; }
    }
}
