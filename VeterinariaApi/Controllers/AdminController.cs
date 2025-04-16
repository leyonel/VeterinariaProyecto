using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VeterinariaAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace VeterinariaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Administrador")]
    public class AdminController : ControllerBase
    {
        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            return Ok("Bienvenido al panel del administrador.");
        }

        [HttpGet("GestionUsuarios")]
        public IActionResult GestionUsuarios()
        {
            return Ok("Aquí puedes gestionar todos los usuarios.");
        }
    }
}

