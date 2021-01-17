using System;
using System.Collections.Generic;

namespace Taller.DAL.Models
{
    public partial class Mecanico
    {
        public Mecanico()
        {
            Especialidades = new HashSet<Especialidades>();
            Reparacion = new HashSet<Reparacion>();
        }

        public int IdMecanico { get; set; }
        public int UsuarioIdUsuario { get; set; }
        public byte Jefe { get; set; }

        public virtual ICollection<Especialidades> Especialidades { get; set; }
        public virtual ICollection<Reparacion> Reparacion { get; set; }
    }
}
