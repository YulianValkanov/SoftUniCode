﻿
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftJail.Data.Models
{
     public class Cell
    {
        [Key]
        public int Id { get; set; }

        [Range(1,1000)]
        [Required]
        public int CellNumber { get; set; }

        [Required]
        public bool HasWindow { get; set; }

        [Required]
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        [Required]
        public Department  Department { get; set; }

        public ICollection<Prisoner> Prisoners { get; set; }


    }
}