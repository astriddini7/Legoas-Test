namespace legoas_test.UseCases.OfficeCases.OfficeGetAll
{
	public class OfficeGetAllResponse
	{
        public IList<OfficeGetAllDto> Offices { get; set; } = default!;
    }

	public record OfficeGetAllDto(string ID, string Name);
}
