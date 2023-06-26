namespace legoas_test.Models
{
	public class ApplicationRole
	{
        public string ID { get; set; } = Guid.NewGuid().ToString("N");
        public string Name { get; set; } = default!;
    }
}
