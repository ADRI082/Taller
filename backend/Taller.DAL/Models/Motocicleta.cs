using System;
using System.Collections.Generic;

namespace Taller.DAL.Models
{
    public partial class Motocicleta
    {
        public int Id { get; set; }
        public int VehiculosIdVehiculo { get; set; }

        public virtual Vehiculo VehiculosIdVehiculoNavigation { get; set; }
    }
}
