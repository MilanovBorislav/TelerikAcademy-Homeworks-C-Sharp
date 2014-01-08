using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }

        [Required]
        public string Name { get; set; }
        public string Country { get; set; }

        public virtual IList<Album> Albums { get; set; }

        public override string ToString()
        {
            return string.Format(
@"
  ArtistId : {0}
  Name     : {1}
  Country  : {2}",this.ArtistId,this.Name,this.Country); 
            
        }
    }
}