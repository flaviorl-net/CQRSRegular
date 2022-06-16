using CQRSRegular.Domain.Seed;
using System.Threading.Tasks;

namespace CQRSRegular.Domain.Aggregates.OportunidadeAggregate
{
    public interface IOportunidadeRepository : IRepository<Oportunidade>
    {
        Oportunidade Add(Oportunidade oportunidade);

        void Update(Oportunidade oportunidade);

        Task<Oportunidade> GetAsync(int oportunidadeId);
    }
}
