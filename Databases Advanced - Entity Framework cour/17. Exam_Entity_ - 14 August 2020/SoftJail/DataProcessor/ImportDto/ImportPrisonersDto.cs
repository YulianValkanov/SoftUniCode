using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoftJail.DataProcessor.ImportDto
{
    class ImportPrisonersDto
    {
    //     "FullName": "Rosmunda Yoodall",
    //"Nickname": "The Lappet",
    //"Age": 46,
    //"IncarcerationDate": "18/05/1965",
    //"ReleaseDate": null,
    //"Bail": 86810.94,
    //"CellId": 17,
    //"Mails": [
    //  {
    //    "Description": "The Images that were sent were old posters when it was a club: lens flare, dancing girls, table service…",
    //    "Sender": "Billye Hakey",
    //    "Address": "64 Sugar Plaza str."
    //  },


        [MinLength(3)]
        [MaxLength(20)]
        [Required]
        public string FullName { get; set; }

        [Required]
        [RegularExpression("^The [A-Z]{1}[a-z]+$")]
        public string Nickname { get; set; }

        [Range(18, 65)]
        [Required]
        public int Age { get; set; }

        [Required]
        public string IncarcerationDate { get; set; }

       
        public string ReleaseDate { get; set; }

     
        
        [Range(0,(double)(decimal.MaxValue))]
        public decimal? Bail { get; set; }


        public int CellId { get; set; }


        public ImportMailsDto[] Mails { get; set; }


    }
    //     "FullName": "",
    //"Nickname": "The Wallaby",
    //"Age": 32,
    //"IncarcerationDate": "29/03/1957",
    //"ReleaseDate": "27/03/2006",
    //"Bail": null,
    //"CellId": 5,
    //"Mails": [
    //  {
    //    "Description": "Invalid FullName",
    //    "Sender": "Invalid Sender",
    //    "Address": "No Address"
    //  },
    //  {
    //    "Description": "Do not put this in your code",
    //    "Sender": "My Ansell",
    //    "Address": "ha-ha-ha"
    //  }
    //]
  
    
}
