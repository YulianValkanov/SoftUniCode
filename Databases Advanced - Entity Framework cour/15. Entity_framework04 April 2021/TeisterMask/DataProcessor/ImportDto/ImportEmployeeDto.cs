using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TeisterMask.Common;

namespace TeisterMask.DataProcessor.ImportDto
{
    public class ImportEmployeeDto
    {
        [Required]
        [MinLength(GlobalConstants.EMPLOYEE_USERNAME_MIN)]
        [MaxLength(GlobalConstants.EMPLOYEE_USERNAME_MAX)]
        [RegularExpression(GlobalConstants.EMPLOYEE_USERNAME_REGEX)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(GlobalConstants.EMPLOYEE_PHONE_REGEX)]
        public string Phone { get; set; }

        public int[] Tasks { get; set; }




        //     "Username": "jstanett0",
        //"Email": "kknapper0@opera.com",
        //"Phone": "819-699-1096",
        //"Tasks": [
        //  34,
        //  32,
        //  65,
        //  30,
        //  30,
        //  45,
        //  36,
        //  67

    }
}
