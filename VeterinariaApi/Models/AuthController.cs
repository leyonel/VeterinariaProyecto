using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

[Route("api/auth")]
[ApiController]

public class AuthController : ControllerBase
{
    private readonly VeterinariaContext _context;
    private readonly AuthService _authService;

    public AuthController(VeterinariaContext context, AuthService authService)
    {
        _context = context;
        _authService = authService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var usuario = await _context.Usuarios
             .FirstOrDefaultAsync(u => u.Correo == request.Correo && u.Contrasena == request.Contrasena);

        if (usuario == null)
            return Unauthorized("Usuario o Conraseña incorrectos");

        var token = _authService.GenerateJwtToken(usuario);

        return Ok(new { Token = token, Rol = usuario.TipoUsuario });
    }

    [Authorize(Roles = "Administrador")]
    [HttpGet("solo-admins")]
    public IActionResult SoloParaAdmins()
    {
        return Ok("Bienvenido Administrador");
    }

    [Authorize(Roles = "Doctor,Administrador")]
    [HttpGet("solo-doctores_administrador")]
    public IActionResult SoloParaDoctores()
    {
        return Ok("Bienvenido Doctor!");
    }

    [Authorize(Roles = "Paciente")]
    [HttpGet("solo-pacientes")]
    public IActionResult SoloParaPacientes()
    {
        return Ok("Bienvenido Paciente!");
    }
}

public class LoginRequest
{
    public string Correo { get; set; }
    public string Contrasena { get; set; }
}