using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.BL.Contracts;
using Taller.Core.DTO;

namespace Taller.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResumenVentasController : ControllerBase
    {
        public IJefeBL _jefeBL { get; set; }

        public ResumenVentasController(IJefeBL jefe)
        {
            _jefeBL = jefe;
        }


        [HttpGet]
        public ActionResult<IEnumerable<ResumenVentasDTO>> Get()
        {
            return Ok(_jefeBL.Get());
        }

    }
}
