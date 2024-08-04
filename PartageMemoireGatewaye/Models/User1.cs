using System.ComponentModel.DataAnnotations;

namespace PartageMemoireGatewaye.Models
{
    public class User1
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; } = String.Empty;
        [Required]
        public string email { get; set; } = String.Empty;
    }
}
