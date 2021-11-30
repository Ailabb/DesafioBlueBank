using Application.Interfaces;
using Application.Requests;
using Application.Responses;
using BankManagement.Entities;
using BankManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands
{
    public class AddClienteCommand : IAddClienteCommand
    {
        private readonly IClienteRepository _repository;

        public AddClienteResponse Handle(AddClienteRequest request)
        {
            var cliente = new Cliente(request.Nome, request.Cpf, request.Email, request.Telefone, request.Celular, request.NumeroConta, request.DigitoConta, request.Agencia );

            _repository.Add(cliente);

            return new AddClienteResponse()
            {
                Nome = cliente.Nome,
                Cpf = cliente.Cpf,
                Email = cliente.Email,
                Telefone = cliente.Telefone,
                Celular = cliente.Celular,
                NumeroConta = cliente.NumeroConta,
                DigitoConta = cliente.DigitoConta,
                Agencia = cliente.Agencia
            };
        }
    }
}
