using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoftJail.DataProcessor.ImportDto
{
    public class ImportMailsDto
    {
        [Required]
        public string Description { get; set; }

        [Required]
        public string Sender { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9 ]+str.$")]
        public string Address { get; set; }

      





        //    "Description": "Invalid FullName",
        //    "Sender": "Invalid Sender",
        //    "Address": "No Address"
        //  },
        //  {
        //    "Description": "Do not put this in your code",
        //    "Sender": "My Ansell",
        //    "Address": "ha-ha-ha"

    }
}
