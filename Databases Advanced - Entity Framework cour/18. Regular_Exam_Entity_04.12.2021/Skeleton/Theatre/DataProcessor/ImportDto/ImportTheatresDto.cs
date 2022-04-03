using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Theatre.DataProcessor.ImportDto
{
    public class ImportTheatresDto
    {

        [MinLength(4)]
        [MaxLength(30)]
        [Required]
        public string Name { get; set; }

        //SBITE
        [Range(1, 10)]
        [Required]
        public sbyte NumberOfHalls { get; set; }

        [MinLength(4)]
        [MaxLength(30)]
        [Required]
        public string Director { get; set; }


        public ImportTicketsDto[] Tickets { get; set; }


    }


    // "Name": "",
    //"NumberOfHalls": 7,
    //"Director": "Ulwin Mabosty",
    //"Tickets": [

    //  {
    //    "Price": 7.63,
    //    "RowNumber": 5,
    //    "PlayId": 4
    //  },
    //  {
    //    "Price": 47.96,
    //    "RowNumber": 9,
    //    "PlayId": 3
    //  }
    //]
}
