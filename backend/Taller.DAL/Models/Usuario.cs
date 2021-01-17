using System;
using System.Collections.Generic;

namespace Taller.DAL.Models
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Apellidos { get; set; }
        public string Name { get; set; }
        public string Rol { get; set; }
        public int ConcesionarioIdConcesionario { get; set; }

        public virtual Concesionario ConcesionarioIdConcesionarioNavigation { get; set; }
    }
}
