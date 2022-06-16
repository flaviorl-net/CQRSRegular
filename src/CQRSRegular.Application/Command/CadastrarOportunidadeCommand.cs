using CQRSRegular.Domain.Seed;
using System;

namespace CQRSRegular.Application.Command
{
    public class CadastrarOportunidadeCommand : ICommand<bool>
    {
        public string Descricao { get; private set; }

        public string Observacao { get; set; }

        public Guid ProspectId { get; private set; }

        public Guid ProdutoServicoId { get; private set; }

        public Guid OrigemOportunidadeId { get; private set; }

        public Guid UsuariosId { get; private set; }

        public CadastrarOportunidadeCommand(string descricao, string observacao, Guid prospectId, Guid produtoServicoId, Guid origemOportunidadeId, Guid usuariosId)
        {
            Descricao = descricao;
            Observacao = observacao;
            ProspectId = prospectId;
            ProdutoServicoId = produtoServicoId;
            OrigemOportunidadeId = origemOportunidadeId;
            UsuariosId = usuariosId;
        }
    }
}
