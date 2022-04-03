using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftJail.Data.Models
{
    public class Prisoner
    {
        [Key]
        public int Id { get; set; }

        [MinLength(3)]
        [MaxLength(20)]
        [Required]
        public string FullName { get; set; }

        [Required]
        public string Nickname { get; set; }

        [Range(18, 65)]
        [Required]
        public int Age { get; set; }


        public DateTime IncarcerationDate { get; set; }

   
        public DateTime? ReleaseDate { get; set; }

        ///!!!!!!!!!!!!!!!!!!!!!!

        [Range(0, (double)(decimal.MaxValue))]
        public decimal? Bail { get; set; }

        [ForeignKey("Cell")]
        public int CellId { get; set; }

   
        public Cell Cell { get; set; }

        public ICollection<Mail> Mails { get; set; }

        public ICollection<OfficerPrisoner> PrisonerOfficers { get; set; }
    }

}