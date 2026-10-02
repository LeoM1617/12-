using System.ComponentModel.DataAnnotations;

namespace WebAutoApp11.Data.Domain
{
    public class Cars
    {
        public int Id { get; set; }

        [Required]
        public string Model { get; set; } = null!;

        public string Picture { get; set; } = null!;

        [Required]
        [Range(0, 500)]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; }
            = new List<Order>();
    }
}
