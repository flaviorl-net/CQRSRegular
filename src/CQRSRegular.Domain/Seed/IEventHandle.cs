using MediatR;

namespace CQRSRegular.Domain.Seed
{
    public interface IEventHandle<in TNotification> : INotificationHandler<TNotification>
        where TNotification : IEvent{ }
}
