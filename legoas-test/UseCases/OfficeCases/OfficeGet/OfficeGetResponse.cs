namespace legoas_test.UseCases.OfficeCases.OfficeGet
{
	public class OfficeGetResponse
	{
        public OfficeGetDto Office { get; set; } = default!;
    }
	
	public record OfficeGetDto(string ID, string Name);
}
