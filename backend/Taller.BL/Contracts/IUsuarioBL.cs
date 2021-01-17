using System;
using System.Collections.Generic;
using System.Text;
using Taller.Core.DTO;

namespace Taller.BL.Contracts
{
    public interface IUsuarioBL
    {
        bool Login(UsuarioDTO usuarioDTO);
        void Add(UsuarioDTO usuarioDTO);
        IEnumerable<UsuarioDTO> Get();
    }
}
