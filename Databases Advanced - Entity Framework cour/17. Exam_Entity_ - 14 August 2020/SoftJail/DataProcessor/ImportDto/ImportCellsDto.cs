using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoftJail.DataProcessor.ImportDto
{
   public  class ImportCellsDto
    {


        [Range(1, 1000)]
        [Required]
        public int CellNumber { get; set; }

        [Required]
        public bool HasWindow { get; set; }

       







        //"Name": "CSS",
        //"Cells": [
        //  {
        //    "CellNumber": 0,
        //    "HasWindow": true
        //  },
        //  {
        //    "CellNumber": 202,
        //    "HasWindow": false
        //  }
        //]
    }
}
