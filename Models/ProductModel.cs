using System.ComponentModel.DataAnnotations;

namespace EddiesHikingStore.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is required.")]
        public string ProductName { get; set; } = "Default Name";

        [Required(ErrorMessage = "Product Description is required.")]
        public string ProductDescription { get; set; } = "Default Description";

        [Required(ErrorMessage = "Product Image is required.")]
        public string ProductImage { get; set; } = "Default Image";

        [DataType(DataType.Currency)]
        public decimal ProductPrice { get; set; }

        // Constructor with default values
        public ProductModel()
        {
            // You can optionally set the ProductPrice here if it has a default value.
        }
    }
}
