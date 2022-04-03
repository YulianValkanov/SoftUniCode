using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Theatre.DataProcessor.ImportDto
{
    public class ImportTicketsDto
    {

        [Range(1.00, 100.00)]
        [Required]
        public decimal Price { get; set; }

        [Range(1, 10)]
        [Required]
        public sbyte RowNumber { get; set; }
        /// <summary>
        /// initialize Play
        /// </summary>
        /// 
        [Required]
        public int PlayId { get; set; }

    }

    //    "Price": 7.63,
    //    "RowNumber": 5,
    //    "PlayId": 4
   
 
}
