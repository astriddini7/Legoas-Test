namespace legoas_test.UseCases.ApplicationUserCases.ApplicationUserGet
{
	public class ApplicationUserGetResponse
	{
		public ApplicationUserGetDto ApplicationUser { get; set; } = default!;
    }

	public record ApplicationUserGetDto
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
