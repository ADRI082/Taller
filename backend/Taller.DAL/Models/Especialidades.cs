using System;
using System.Collections.Generic;

namespace Taller.DAL.Models
{
    public partial class Especialidades
    {
        public string EspecialidadEspecialidad { get; set; }
        public int MecanicoIdMecanico { get; set; }

        public virtual Especialidad EspecialidadEspecialidadNavigation { get; set; }
        public virtual Mecanico MecanicoIdMecanicoNavigation { get; set; }
    }
}
