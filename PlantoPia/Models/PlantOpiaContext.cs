using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PlantoPia.Models
{
	public class PlantOpiaContext : IdentityDbContext<Users>
	{
		public PlantOpiaContext() : base() { }

		public PlantOpiaContext(DbContextOptions<PlantOpiaContext> options) : base(options) { }
		
		public DbSet<Users> users { get; set; }
	}
}
