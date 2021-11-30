using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Handlers
{
    public interface IHandler<TRequest, TResponse>
    {
        TResponse Handle(TRequest request);
    }
}
