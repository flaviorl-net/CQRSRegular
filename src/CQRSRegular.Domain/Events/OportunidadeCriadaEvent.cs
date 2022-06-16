using CQRSRegular.Domain.Seed;
using System;

namespace CQRSRegular.Domain.Events
{
    public class OportunidadeCriadaEvent
        : IEvent
    {
        public Guid OportunidadeId { get; private set; }

        public OportunidadeCriadaEvent(Guid oportunidadeId)
        {
            OportunidadeId = oportunidadeId;
        }
    }
}
