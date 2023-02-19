namespace Puffin.DataAccess.Entities
{
	public class Feather
	{
		required public Guid Id { get; set; }
		public string? Name { get; set; }
		public int? Weight { get; set; }
		public int? Price { get; set; }
		public bool InStock { get; set; } = false;
	}
}

