using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Theatre.Data.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [Range(1.00,100.00)]
        [Required]
        public decimal Price { get; set; }


        [Range(1,10)]
        [Required]
        public sbyte RowNumber { get; set; }
        /// <summary>
        /// initialize Play
        /// </summary>
        [Required]
        [ForeignKey("Play")]
        public int PlayId { get; set; }


        public Play Play { get; set; }

        /// <summary>
        /// imitial;ize Theatre
        /// </summary>
        [Required]
        [ForeignKey("Theatre")]
        public int TheatreId { get; set; }

        public Theatre Theatre { get; set; }

    }
}
