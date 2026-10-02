using System.ComponentModel.DataAnnotations;

namespace WebAutoApp11.Data.Domain
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public int CarId { get; set; }

        [Required]
        public virtual Cars Car { get; set; } = null!;

        [Required]
        public int ClientId { get; set; }

        [Required]
        public virtual Client Client { get; set; } = null!;

        [Required]
        public DateTime OrderDate { get; set; }
    }
}
