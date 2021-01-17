using System;
using System.Collections.Generic;
using System.Text;
using Taller.Core.DTO;

namespace Taller.BL.Contracts
{
    public interface IJefeBL
    {
        IEnumerable<ResumenVentasDTO> Get();

    }
}
