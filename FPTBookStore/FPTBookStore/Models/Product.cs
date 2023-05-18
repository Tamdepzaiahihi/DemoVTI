using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace FPTBookStore.Models
{
	public class Product
	{
		public long? ProductID { get; set; }

		[Required(ErrorMessage ="Please enter product name")]
		public string Name { get; set; } = String.Empty;

		[Required(ErrorMessage = "Please enter description")]
		public string Description { get; set; } = String.Empty;		

		[Required]
		[Range(0.01, double.MaxValue,
			ErrorMessage = "Please enter price")]
		[Column(TypeName = "decimal(8,2)")]
		public decimal Price { get; set; }

		[Required(ErrorMessage = "Please enter category")]
		public string Category { get; set; } = String.Empty;

        public string Picture { get; set; } = string.Empty;
		
		public void AddPicture(string picture)
		{
			Picture = picture;
		}

	}
}
