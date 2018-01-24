using System.ComponentModel.DataAnnotations;

namespace WebApplication1
{
    public class CustomerMetadata
    {
        public int Id;

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(25, MinimumLength = 2)]
        public string FirstName;

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(25, MinimumLength = 2)]
        public string LastName;

        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress]
        public string Email;
    }

    [MetadataType(typeof(CustomerMetadata))]
    public partial class Customer { }

    public class OrderMetadata
    {
        public int Id;
        
        public int CustomerId;
        
        public int ProductId;
        
        public int OrderQuantity;
    }

    [MetadataType(typeof(OrderMetadata))]
    public partial class Order { }

    public class ProductMetadata
    {
        public int Id;

        [Required(ErrorMessage = "Product Name is required")]
        [StringLength(25, MinimumLength = 2)]
        public string Name;

        [Required(ErrorMessage = "Product Cost is required")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Cost;

        [Required(ErrorMessage = "Product quantity is required")]
        [Range(0, 100, ErrorMessage = "Quanity can only be between 0 and 100")]
        public int Quantity;
    }

    [MetadataType(typeof(ProductMetadata))]
    public partial class Product { }
}