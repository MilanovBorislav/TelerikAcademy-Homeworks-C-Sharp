using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }

        [Required]
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }

        public Artist Artist { get; set; }

        public override string ToString()
        {
            return string.Format(
@"
  SongId   : {0}
  Title    : {1}
  Year     : {2}", this.SongId, this.Title, this.Year);

        }
    }
}