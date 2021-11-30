using BankManagement.Entities;
using BankManagement.Interfaces;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(BankSystemContext context) : base(context) { }

        public void Add(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Cliente> Get(Expression<Func<Cliente, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Cliente GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente product)
        {
            throw new NotImplementedException();
        }
    }
}
