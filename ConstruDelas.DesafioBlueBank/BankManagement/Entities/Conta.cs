using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagement.Entities
{
    public class Conta : Entity
    {
       
        public decimal Saldo { get; set; }
        public virtual Cliente Cliente { get; set; }
        public Guid ClienteId { get; set; }
        public int NumeroConta { get; set; }
        public int DigitoConta { get; set; }
        public int Agencia { get; set; }

        public Conta (decimal saldo, Guid clienteId, int numeroConta, int digitoConta, int agencia)
        {
            Saldo = saldo;
            ClienteId = clienteId;
            NumeroConta = numeroConta;
            DigitoConta = digitoConta;
            Agencia = agencia;

        }
    }
}
