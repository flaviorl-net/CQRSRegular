using System.Threading;
using System.Threading.Tasks;

namespace CQRSRegular.Domain.Seed
{
    public interface IMediator
    {
        Task PublishEvent(object notification, CancellationToken cancellationToken = default);

        Task PublishEvent<TNotification>(TNotification notification, CancellationToken cancellationToken = default) where TNotification : IEvent;

        Task<TResponse> SendCommand<TResponse>(ICommand<TResponse> request, CancellationToken cancellationToken = default);

        Task<object> SendCommand(object request, CancellationToken cancellationToken = default);
    }
}
