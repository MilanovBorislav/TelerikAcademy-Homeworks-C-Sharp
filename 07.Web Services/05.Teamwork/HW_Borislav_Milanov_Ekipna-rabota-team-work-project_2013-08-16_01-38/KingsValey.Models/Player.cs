using System.ComponentModel.DataAnnotations;

namespace KingsValey.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }

        [Required, MaxLength(15), MinLength(6)]
        public string Name { get; set; }

        public int Victories { get; set; }

        public int Losses { get; set; }

        public string Avatar { get; set; }

        [Required, StringLength(40)]
        public string Password { get; set; }

        [StringLength(40)]
        public string SessionKey { get; set; }
    }
}