using System;
using System.Collections.Generic;
using System.Text;
using Taller.BL.Contracts;
using Taller.Core.DTO;
using Taller.DAL.Repositories.Contracts;
using Taller.DAL.Repositories.Implementations;

namespace Taller.BL.Implementations
{
    public class JefeBL : IJefeBL
    {
        public IJefeRepository _jefeRepository { get; set; }

        public JefeBL(IJefeRepository jefeRepository)
        {
            _jefeRepository = jefeRepository;
        }


        public IEnumerable<ResumenVentasDTO> Get()
        {
            var resumen = _jefeRepository.Get();
           return resumen ;
        }
    }
}
