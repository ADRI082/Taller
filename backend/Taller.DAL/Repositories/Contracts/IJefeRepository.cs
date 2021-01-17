using System;
using System.Collections.Generic;
using System.Text;
using Taller.Core.DTO;

namespace Taller.DAL.Repositories.Contracts
{
    public interface IJefeRepository
    {

        IEnumerable<ResumenVentasDTO> Get();

    }
}
