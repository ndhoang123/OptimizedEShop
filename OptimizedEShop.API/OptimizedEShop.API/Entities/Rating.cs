using System.ComponentModel.DataAnnotations.Schema;

namespace OptimizedEShop.API.Entities
{
	public class Rating
	{
		public int Id { get; set; }

		public int Val { get; set; }

		public string Comment { get; set; }

		[ForeignKey("User")]
		public string UserId { get; set; }

		public User User { get; set; }
		[ForeignKey("Product")]

		public int ProductId { get; set; }

		public Product Product { get; set; }
	}
}
