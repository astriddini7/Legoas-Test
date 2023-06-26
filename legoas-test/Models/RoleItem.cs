namespace legoas_test.Models
{
	public class RoleItem
	{
        public string ID { get; set; } = Guid.NewGuid().ToString("N");
        public string Name { get; set; } = default!;
    }
}
