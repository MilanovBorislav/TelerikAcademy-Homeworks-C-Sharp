using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }

        [Required]
        public string Title { get; set; }
        public virtual DateTime? ReleaseDate { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }
        public virtual ICollection<Song> Songs { get; set; }

        public Album()
        {
            this.Artists = new HashSet<Artist>();
            this.Songs = new HashSet<Song>();
        }

        public override string ToString()
        {
            return string.Format(
@"
  AlbumId   : {0}
  Title     : {1}
  Year      : {2}", this.AlbumId, this.Title, this.ReleaseDate);

        }
    }
}
