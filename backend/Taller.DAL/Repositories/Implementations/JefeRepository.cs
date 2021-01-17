using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Taller.Core.DTO;
using Taller.DAL.Models;
using Taller.DAL.Repositories.Contracts;

namespace Taller.DAL.Repositories.Implementations
{
    public class JefeRepository : IJefeRepository
    {

        public ConcesionarioDBContext _context { get; set; }


        public JefeRepository (ConcesionarioDBContext context)
        {
            _context =  context;
        }

        public IEnumerable<ResumenVentasDTO> Get()
        {



            List<ResumenVentasDTO> resumenVentas = new List<ResumenVentasDTO>();



            var query = from p in _context.Propuesta
                        group p by p.VentasIdVentas into g
                        select new
                        {
                            idVentas = g.Key,
                            Total = g.Sum(p => p.Precio),
                            Transacciones = g.Count()
                        };


            foreach (var resumenQuery in query.ToList())
            {
                var usuarioId = _context.Ventas.Where(v => v.IdVentas == resumenQuery.idVentas).Select(v => v.UsuarioIdUsuario).FirstOrDefault();
                var nombreUsuario = _context.Usuario.Where(v => v.IdUsuario == usuarioId).Select(v => v.Name).FirstOrDefault();

                var resumen = new ResumenVentasDTO
                {
                    User = nombreUsuario,
                    Beneficios = resumenQuery.Total,
                    Transacciones = resumenQuery.Transacciones
                };

                resumenVentas.Add(resumen);

            };


            return resumenVentas;

        }


    }
}
