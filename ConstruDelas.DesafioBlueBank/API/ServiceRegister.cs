using Application.Commands;
using Application.Interfaces;
using BankManagement.Interfaces;
using Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construdelas.BlueBank.Services.API
{
    public class ServiceRegister
    {
        public static void Register(IServiceCollection services)
        {
            RegisterRespositories(services);
            RegisterCommands(services);
            RegisterQueries(services);
        }

        private static void RegisterCommands(IServiceCollection services)
        {
            services.AddSingleton<IAddClienteCommand, AddClienteCommand>();
            //services.AddSingleton<IUpdateProductCommand, UpdateProductCommand>();
            //services.AddSingleton<IRemoveProductByIdCommand, RemoveProductByIdCommand>();
            //services.AddSingleton<IProductChangeStatusCommand, ProductChangeStatusCommand>();
        }

        private static void RegisterQueries(IServiceCollection services)
        {
            //services.AddSingleton<IGetProductByIdQuery, GetProductByIdQuery>();
            //services.AddSingleton<IGetAllProductQuery, GetAllProductQuery>();
        }

        private static void RegisterRespositories(IServiceCollection services)
        {
            services.AddSingleton<IClienteRepository, ClienteRepository>();
            services.AddSingleton<IContaRepository, ContaRepository>();
            //services.AddSingleton<IOrderItemRepository, OrderItemRepository>();
            //services.AddSingleton<IOrderRepository, OrderRepository>();
        }
    }
}
