using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int NumeroConta { get; set; }
        public int DigitoConta { get; set; }
        public int Agencia { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
    }
}
