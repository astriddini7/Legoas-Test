using Microsoft.AspNetCore.Identity;

namespace legoas_test.Models
{
	public class ApplicationUser : IdentityUser
	{
		public string FullName { get; set; } = default!;
		public string Address { get; set; } = default!;
		public DateTime RegisterDate { get; set; } = DateTime.UtcNow;
		public string PostalCode { get; set; } = default!;
		public string Province { get; set; } = default!;
		public string Office { get; set; } = default!;
    }
}
