using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taller.Core.DTO;
using Taller.DAL.Models;
using Taller.DAL.Repositories.Contracts;

namespace Taller.DAL.Repositories.Implementations
{
    public class UsuarioRepository : IUsuarioRepository
    {

        public ConcesionarioDBContext _context { get; set; }

        public UsuarioRepository(ConcesionarioDBContext context)
        {
            _context = context;
        }

        public bool Login(UsuarioDTO usuarioDTO)
        {

            return _context.Usuario.Any(u => u.User == usuarioDTO.Username &&
                                    u.Password == usuarioDTO.Password);
        }

        public void Add(UsuarioDTO usuarioDTO)
        {
            var usuario = new Usuario
            {
                User = usuarioDTO.Username,
                Password = usuarioDTO.Password,
                Name = usuarioDTO.Name,
                Apellidos = usuarioDTO.Apellidos,
                Email = usuarioDTO.Email,
                Rol = usuarioDTO.Rol,
                ConcesionarioIdConcesionario = 1
            };
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
        }

        public IEnumerable<UsuarioDTO> Get()
        {
            var usuarios = _context.Usuario.ToList();
       

            //Mapeo de Usuario a UsuarioDTO
            List<UsuarioDTO> usuariosdto = new List<UsuarioDTO>();

            foreach (var u in usuarios)
            {
                var usuario = new UsuarioDTO
                {
                    Username = u.User,
                    Password = u.Password,
                    Name = u.Name,
                    Apellidos = u.Apellidos,
                    Email = u.Email,
                    Rol = u.Rol
                };
                usuariosdto.Add(usuario);
            }

            return usuariosdto;

        }
    }
}
