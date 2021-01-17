using System;
using System.Collections.Generic;

namespace Taller.DAL.Models
{
    public partial class Vehiculo
    {
        public Vehiculo()
        {
            Coche = new HashSet<Coche>();
            Motocicleta = new HashSet<Motocicleta>();
            Propuesta = new HashSet<Propuesta>();
            ReparacionNavigation = new HashSet<Reparacion>();
        }

        public int IdVehiculo { get; set; }
        public string Matricula { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Precio { get; set; }
        public int Año { get; set; }
        public int? Kilometros { get; set; }
        public string Combustible { get; set; }
        public byte? Reparacion { get; set; }
        public byte? Reparado { get; set; }
        public byte? Venta { get; set; }
        public byte? Vendido { get; set; }
        public int? VentasIdVentas { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime? FechaSalida { get; set; }
        public int? ClienteIdCliente { get; set; }
        public int ConcesionarioIdConcesionario { get; set; }
        public byte[] Imagen { get; set; }

        public virtual Cliente ClienteIdClienteNavigation { get; set; }
        public virtual Concesionario ConcesionarioIdConcesionarioNavigation { get; set; }
        public virtual Ventas VentasIdVentasNavigation { get; set; }
        public virtual ICollection<Coche> Coche { get; set; }
        public virtual ICollection<Motocicleta> Motocicleta { get; set; }
        public virtual ICollection<Propuesta> Propuesta { get; set; }
        public virtual ICollection<Reparacion> ReparacionNavigation { get; set; }
    }
}
