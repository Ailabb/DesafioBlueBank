using Application.Requests;
using Application.Responses;
using Shared.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IGetClienteByIdQuery : IHandler<GetClienteByIdRequest, GetClienteByIdResponse>
    {
    }
}
