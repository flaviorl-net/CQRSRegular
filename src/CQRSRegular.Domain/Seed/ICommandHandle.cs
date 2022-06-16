using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSRegular.Domain.Seed
{
    public interface ICommandHandle<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
        where TRequest : ICommand<TResponse>{ }
}
