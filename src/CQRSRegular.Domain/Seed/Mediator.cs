using System.Threading;
using System.Threading.Tasks;

namespace CQRSRegular.Domain.Seed
{
    public class Mediator : IMediator
    {
        private readonly MediatR.IMediator _mediator;

        public Mediator(MediatR.IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task PublishEvent(object notification, CancellationToken cancellationToken = default)
        {
            return _mediator.Publish(notification, cancellationToken);
        }

        public Task PublishEvent<TNotification>(TNotification notification, CancellationToken cancellationToken = default) where TNotification : IEvent
        {
            return _mediator.Publish(notification, cancellationToken);
        }

        public Task<TResponse> SendCommand<TResponse>(ICommand<TResponse> request, CancellationToken cancellationToken = default)
        {
            return _mediator.Send(request, cancellationToken);
        }

        public Task<object> SendCommand(object request, CancellationToken cancellationToken = default)
        {
            return _mediator.Send(request, cancellationToken);
        }
    }
}
