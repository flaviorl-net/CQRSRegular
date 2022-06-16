using CQRSRegular.Application.Command;
using CQRSRegular.Domain.Aggregates.OportunidadeAggregate;
using CQRSRegular.Domain.Seed;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSRegular.Application.CommandHandle
{
    public class CadastrarOportunidadeCommandHandle 
        : ICommandHandle<CadastrarOportunidadeCommand, bool>
    {
        private readonly IOportunidadeRepository _oportunidadeRepository;

        public CadastrarOportunidadeCommandHandle(IOportunidadeRepository oportunidadeRepository)
        {
            _oportunidadeRepository = oportunidadeRepository;
        }

        public Task<bool> Handle(CadastrarOportunidadeCommand request, CancellationToken cancellationToken)
        {
            var oportunidade = new Oportunidade(Guid.NewGuid(), request.Descricao, request.Observacao, request.ProspectId,
                request.ProdutoServicoId, request.OrigemOportunidadeId, request.UsuariosId);

            _oportunidadeRepository.Add(oportunidade);
            _oportunidadeRepository.UnitOfWork.SaveChangesAsync();

            return Task.FromResult(true);
        }
    }
}
