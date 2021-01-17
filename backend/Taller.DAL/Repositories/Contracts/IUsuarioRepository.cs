using System;
using System.Collections.Generic;
using System.Text;
using Taller.Core.DTO;

namespace Taller.DAL.Repositories.Contracts
{
    public interface IUsuarioRepository
    {
        bool Login(UsuarioDTO usuarioDTO);
        void Add(UsuarioDTO usuarioDTO);
        IEnumerable<UsuarioDTO> Get();
    }
}
