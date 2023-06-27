namespace legoas_test.UseCases.RoleItemCases.RoleItemGetAll
{
	public class RoleItemGetAllResponse
	{
		public IList<RoleItemGetAllDto> RoleItems { get; set; } = default!;
    }

	public record RoleItemGetAllDto(string ID, string Name);
}
