using CQRSRegular.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSRegular.Application.Interfaces.Queries
{
    public interface IOportunidadeQuery
    {
        Task<List<OportunidadeViewModel>> ObterOportunidades();

        OportunidadeViewModel ObterOportunidade(Guid id);
    }
}
