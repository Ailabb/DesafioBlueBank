using BankManagement.Entities;
using BankManagement.Interfaces;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class ContaRepository : RepositoryBase<Conta>, IContaRepository
    {
        public ContaRepository(BankSystemContext context) : base(context) { }
    }
}
