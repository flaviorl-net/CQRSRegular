using CQRSRegular.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSRegular.Domain.Aggregates.OportunidadeAggregate
{
    public class Oportunidade : Entity<Guid>, IAggregateRoot
    {
        public string Descricao { get; private set; }

        public string Observacao { get; private set; }

        public Guid ProspectId { get; private set; }

        public Guid ProdutoServicoId { get; private set; }

        public Guid OrigemOportunidadeId { get; private set; }

        public IReadOnlyCollection<StatusOportunidade> StatusOportunidade { get; set; }

        public Guid UsuariosId { get; private set; }

        protected Oportunidade() { }

        public Oportunidade(Guid id, string descricao, string observacao, Guid prospectId,
            Guid produtoServicoId, Guid origemOportunidadeId, Guid usuariosId)
        {
            Id = id;
            Descricao = descricao;
            Observacao = observacao;
            UsuariosId = usuariosId;
            OrigemOportunidadeId = origemOportunidadeId;
            ProdutoServicoId = produtoServicoId;
            ProspectId = prospectId;
        }



    }
}
