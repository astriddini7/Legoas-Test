using legoas_test.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace legoas_test.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<ApplicationUser> ApplicationUsers { get; set; } = default!;
		public DbSet<Office> Offices { get; set; } = default!;
		public DbSet<ApplicationRole> ApplicationRoles { get; set; } = default!;
		public DbSet<RoleItem> RoleItems { get; set; } = default!;
	}
}