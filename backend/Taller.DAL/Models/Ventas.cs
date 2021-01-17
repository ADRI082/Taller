using System;
using System.Collections.Generic;

namespace Taller.DAL.Models
{
    public partial class Ventas
    {
        public Ventas()
        {
            Propuesta = new HashSet<Propuesta>();
            Vehiculo = new HashSet<Vehiculo>();
        }

        public int IdVentas { get; set; }
        public int UsuarioIdUsuario { get; set; }

        public virtual ICollection<Propuesta> Propuesta { get; set; }
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
    }
}
