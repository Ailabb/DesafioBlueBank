using Application.Requests;
using Application.Responses;
using Shared.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Interfaces
{
    public interface IGetAllClienteQuery : IHandler<GetAllClienteRequest, IQueryable<GetAllClienteResponse>>
    {
    }
}
