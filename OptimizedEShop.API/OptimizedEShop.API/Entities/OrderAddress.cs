using System.ComponentModel.DataAnnotations;

namespace OptimizedEShop.API.Entities
{
	public class OrderAddress
	{
		public long Id { get; set; }

		[StringLength(450)]
		public string Name { get; set; }

		[StringLength(450)]
		public int Phone { get; set; }

		[StringLength(450)]
		public string Address { get; set; }

		[StringLength(450)]
		public string District { get; set; }

		[StringLength(450)]
		public string City { get; set; }
	}
}
