using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSRegular.Domain.Seed
{
    public  interface IRepository<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
