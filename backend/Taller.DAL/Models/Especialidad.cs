using System;
using System.Collections.Generic;

namespace Taller.DAL.Models
{
    public partial class Especialidad
    {
        public Especialidad()
        {
            Especialidades = new HashSet<Especialidades>();
        }

        public string Especialidad1 { get; set; }

        public virtual ICollection<Especialidades> Especialidades { get; set; }
    }
}
