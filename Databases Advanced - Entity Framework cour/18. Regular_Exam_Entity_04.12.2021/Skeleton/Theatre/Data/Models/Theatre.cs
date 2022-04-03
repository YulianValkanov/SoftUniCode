using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Theatre.Data.Models
{
    public class Theatre
    {
        public Theatre()
        {
            this.Tickets = new HashSet<Ticket>();
        }


        [Key]
        public int Id { get; set; }

        [MinLength(4)]
        [MaxLength(30)]
        [Required]
        public string Name { get; set; }

        //SBITE
        [Range(1,10)]
        [Required]
         public sbyte NumberOfHalls { get; set; }

        [MinLength(4)]
        [MaxLength(30)]
        [Required]
        public string Director { get; set; }

      
        public ICollection<Ticket> Tickets { get; set; }



    }
}
