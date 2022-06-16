using CQRSRegular.Domain.Events;
using CQRSRegular.Domain.Seed;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSRegular.Application.DomainEventHandlers
{
    public class OportunidadeCriadaEventHandle : IEventHandle<OportunidadeCriadaEvent>
    {
        public Task Handle(OportunidadeCriadaEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
