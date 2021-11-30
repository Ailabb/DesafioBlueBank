using BankManagement.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    public class BankSystemContext : DbContext
    {
        public BankSystemContext(DbContextOptions<BankSystemContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Conta> Conta { get; set; }
    }
}
