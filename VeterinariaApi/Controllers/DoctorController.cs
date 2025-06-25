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
    [Authorize(Roles = "Doctor,Administrador")]
    public class DoctorController : ControllerBase
    {
        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            return Ok("Bienvenido al panel del doctor.");
        }
        [HttpGet("GestionPacientes")]
        public IActionResult GestionPacientes()
        {
            return Ok("Aquí puedes gestionar todos los pacientes.");
        }
    }
}