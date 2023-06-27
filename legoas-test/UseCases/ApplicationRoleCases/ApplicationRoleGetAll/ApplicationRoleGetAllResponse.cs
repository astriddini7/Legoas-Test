namespace legoas_test.UseCases.ApplicationRoleCases.ApplicationRoleGetAll
{
	public class ApplicationRoleGetAllResponse
	{
		public IList<ApplicationRoleGetAllDto> ApplicationRoles { get; set; } = default!;
    }
	
	public record ApplicationRoleGetAllDto(string ID, string Name);
}
