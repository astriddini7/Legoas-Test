namespace legoas_test.UseCases.ApplicationRoleCases.ApplicationRoleGet
{
	public class ApplicationRoleGetResponse
	{
		public ApplicationRoleGetDto ApplicationRole { get; set; } = default!;
    }

	public record ApplicationRoleGetDto(string ID, string Name);
}
