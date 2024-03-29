﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer.DTO.ImportDTO
{
    [XmlType("Customer")]
    public class ImportCustomersDto
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("birthDate")]
        public string BirthDate { get; set; }

        [XmlElement("isYoungDriver")]
        public string IsYoungDriver { get; set; }


        // <Customer>
        //<name>Emmitt Benally</name>
        //<birthDate>1993-11-20T00:00:00</birthDate>
        //<isYoungDriver>true</isYoungDriver>




    }
}
