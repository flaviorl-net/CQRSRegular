using MediatR;

namespace CQRSRegular.Domain.Seed
{
    public interface ICommand<out T> : IRequest<T> { }
}
