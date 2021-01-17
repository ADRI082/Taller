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
    public class LoginController : ControllerBase
    {
        public IUsuarioBL _usuarioBL { get; set; }

        public LoginController(IUsuarioBL pollo)
        {
            _usuarioBL = pollo;
        }

        [HttpPost]
        public bool Login(UsuarioDTO usuarioDTO)
        {
            return _usuarioBL.Login(usuarioDTO);
        }

        [HttpGet]
        public string holi()
        {
            return "Holi";
        }
    }
}
