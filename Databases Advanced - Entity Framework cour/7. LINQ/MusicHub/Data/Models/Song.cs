using MusicHub.Command;
using MusicHub.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicHub.Data.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.SONG_MAX_VALUE)]
        public string Name { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public Genre Genre { get; set; }

        //todo write navigational proparies
        public int? AlbumId { get; set; }

        public int WriterId { get; set; }

        public decimal Price { get; set; }
   

    }
}
