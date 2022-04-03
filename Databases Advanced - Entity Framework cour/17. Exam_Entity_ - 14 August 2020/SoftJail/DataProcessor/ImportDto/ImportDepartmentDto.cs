using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoftJail.DataProcessor.ImportDto
{
    public class ImportDepartmentDto
    {

       

        [MinLength(3)]
        [MaxLength(25)]
        [Required]
        public string Name { get; set; }

        public ImportCellsDto[] Cells { get; set; }
    }


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
