using Microsoft.EntityFrameworkCore;
using VeterinariaAPI.Models;

public class VeterinariaContext : DbContext
{
	public VeterinariaContext(DbContextOptions<VeterinariaContext> options) : base(options) { }

	public DbSet<Usuario> Usuarios { get; set; }
	public DbSet<Paciente> Pacientes { get; set; }
	public DbSet<HistorialMedico> HistorialMedico { get; set; }
	public DbSet<Inventario> Inventario { get; set; }
	public DbSet<Cita> Citas { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Usuario>()
			.HasIndex(u => u.Correo)
			.IsUnique();
	}
}
