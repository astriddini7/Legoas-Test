namespace legoas_test.UseCases.RoleItemCases.RoleItemGet
{
	public class RoleItemGetResponse
	{
		public RoleItemDto RoleItem { get; set; } = default!;
	}

	public record RoleItemDto(string ID, string Name);
}
