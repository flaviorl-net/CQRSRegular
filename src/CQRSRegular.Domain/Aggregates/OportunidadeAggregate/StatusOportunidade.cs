using CQRSRegular.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSRegular.Domain.Aggregates.OportunidadeAggregate
{
    public class StatusOportunidade : Entity
    {
        public DateTime DataLembrete { get; set; }

        public string Observacao { get; private set; }

        public Guid OportunidadeId { get; private set; }

        public Guid UsuariosId { get; private set; }

        public Oportunidade Oportunidade { get; set; }


        protected StatusOportunidade() { }

        public StatusOportunidade(string observacao, Guid oportunidadeId, Guid usuariosId)
        {
            Observacao = observacao;
            OportunidadeId = oportunidadeId;
            UsuariosId = usuariosId;
        }


    }
}
