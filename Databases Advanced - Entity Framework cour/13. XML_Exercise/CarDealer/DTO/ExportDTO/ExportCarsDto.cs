﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer.DTO.ExportDTO
{

    [XmlType("car")]
    public class ExportCarsDto
    {
        [XmlElement("make")]
        public string Make { get; set; }

        [XmlElement("model")]
        public string Model { get; set; }

        [XmlElement("travelled-distance")]
        public string TravelledDistance { get; set; }


        //        <car>
        //  <make>BMW</make>
        //  <model>1M Coupe</model>
        //  <travelled-distance>39826890</travelled-distance>
        //       </car>

    }
}
