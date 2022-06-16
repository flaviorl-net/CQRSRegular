using System;

namespace CQRSRegular.Application.ViewModel
{
    public class OportunidadeViewModel
    {
        public string Descricao { get; set; }

        public string Observacao { get; set; }

        public Guid ProspectId { get; set; }

        public Guid ProdutoServicoId { get; set; }

        public Guid OrigemOportunidadeId { get; set; }

        public Guid UsuariosId { get; set; }
    }
}
