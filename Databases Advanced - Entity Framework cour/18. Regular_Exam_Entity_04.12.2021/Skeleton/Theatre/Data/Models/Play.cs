using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Theatre.Data.Models.Enums;

namespace Theatre.Data.Models
{
    public class Play
    {
        public Play()
        {
            this.Casts = new HashSet<Cast>();
            this.Tickets = new HashSet<Ticket>();
        }


        [Key]
        public int Id { get; set; }

        [MinLength(4)]
        [MaxLength(50)]
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// CHECK WORKING min Lenght
        /// </summary>
        [Required]
        [MinLength(1)]
        public TimeSpan Duration { get; set; }

        /// <summary>
        /// CHECK FLOAT FORMAT
        /// </summary>
        [Required]
        [Range(0.00,10.00)]
        public float Rating { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [MaxLength(700)]
        [Required]
        public string Description { get; set; }

        [MinLength(4)]
        [MaxLength(30)]
        [Required]
        public string Screenwriter { get; set; }

        public ICollection<Cast> Casts { get; set; }

      
        public ICollection<Ticket> Tickets { get; set; }

    }
}
