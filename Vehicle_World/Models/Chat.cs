using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_World.Models
{
    public class Chat
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public DateTime Timestamp { get; set; }

        [Required]
        public string BuyerId { get; set; }
        public virtual AppUser Buyer { get; set; }

        [Required]
        public string SellerId { get; set; }
        public virtual AppUser Seller { get; set; }


    }
}
