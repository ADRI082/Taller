using System;
using System.Collections.Generic;
using System.Text;
using Taller.BL.Contracts;
using Taller.Core.DTO;
using Taller.DAL.Repositories.Contracts;

namespace Taller.BL.Implementations
{
    public class UsuarioBL : IUsuarioBL
    {

        public IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioBL(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public bool Login(UsuarioDTO usuarioDTO)
        {
            return _usuarioRepository.Login(usuarioDTO);
        }

        public void Add(UsuarioDTO usuarioDTO)
        {
            _usuarioRepository.Add(usuarioDTO);
        }

        public IEnumerable<UsuarioDTO> Get()
        {
            var usuarios = _usuarioRepository.Get();
            return usuarios;
        }

    }
}
