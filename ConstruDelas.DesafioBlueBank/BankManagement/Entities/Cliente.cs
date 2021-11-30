using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagement.Entities
{
    public class Cliente : Entity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public int NumeroConta { get; set; }
        public int DigitoConta { get; set; }
        public int Agencia { get; set; }

        public Cliente (string nome, string cpf, string email, string telefone, string celular, int numeroConta, int digitoConta, int agencia)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Celular = celular;
            NumeroConta = numeroConta;
            DigitoConta = digitoConta;
            Agencia = agencia;
        }
    }
}
