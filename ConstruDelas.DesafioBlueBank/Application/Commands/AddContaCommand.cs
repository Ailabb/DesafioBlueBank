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
    public class AddContaCommand : IAddContaCommand
    {
        private readonly IContaRepository _repository;

        public AddContaResponse Handle(AddContaRequest resquest)
        {
            var conta = new Conta(resquest.Saldo, resquest.ClienteId, resquest.NumeroConta, resquest.DigitoConta, resquest.Agencia);

            _repository.Add(conta);

            return new AddContaResponse()
            {
                Saldo = conta.Saldo,
                ClienteId = conta.ClienteId,
                NumeroConta = conta.NumeroConta,
                DigitoConta = conta.DigitoConta,
                Agencia = conta.Agencia
            };
        }
    }

  }
    
