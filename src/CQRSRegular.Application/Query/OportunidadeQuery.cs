using CQRSRegular.Application.Interfaces.Queries;
using CQRSRegular.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRSRegular.Application.Query
{
    public class OportunidadeQuery : IOportunidadeQuery
    {
        public OportunidadeViewModel ObterOportunidade(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OportunidadeViewModel>> ObterOportunidades()
        {
            throw new NotImplementedException();
        }
    }
}
