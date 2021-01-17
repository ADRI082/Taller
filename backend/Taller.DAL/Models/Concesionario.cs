using System;
using System.Collections.Generic;

namespace Taller.DAL.Models
{
    public partial class Concesionario
    {
        public Concesionario()
        {
            Usuario = new HashSet<Usuario>();
            Vehiculo = new HashSet<Vehiculo>();
        }

        public int IdConcesionario { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
    }
}
