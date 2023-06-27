namespace legoas_test.UseCases.ApplicationUserCases.ApplicationUserGetAll
{
	public class ApplicationUserGetAllResponse
	{
		public IList<ApplicationUserGetAllDto> ApplicationUsers { get; set; } = default!;
    }

	public record ApplicationUserGetAllDto
	{
		string Id { get; set; } = default!;
		string FullName = default!;
		string Address = default!;
		DateTime RegisterDate = default!;
		string PostalCode = default!;
		string Province = default!;
		string Office = default!;
		string UserName = default!;
		string Email = default!;
		string PhoneNumber = default!;
	}
}