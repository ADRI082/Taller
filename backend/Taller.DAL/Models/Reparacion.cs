using System;
using System.Collections.Generic;

namespace Taller.DAL.Models
{
    public partial class Reparacion
    {
        public int IdReparacion { get; set; }
        public int MecanicoIdMecanico { get; set; }
        public int Precio { get; set; }
        public string Descripcion { get; set; }
        public int VehiculosIdVehiculo { get; set; }
        public string Componentes { get; set; }
        public byte Empezado { get; set; }
        public byte Terminado { get; set; }
        public int Tiempo { get; set; }
        public int? IdCliente { get; set; }

        public virtual Mecanico MecanicoIdMecanicoNavigation { get; set; }
        public virtual Vehiculo VehiculosIdVehiculoNavigation { get; set; }
    }
}
