using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer.DTO.ImportDTO
{
    [XmlType("Part")]
    public class ImportPartsDto
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("price")]
        public string Price { get; set; }

        [XmlElement("quantity")]
        public string Quantity { get; set; }

        [XmlElement("supplierId")]
        public int SupplierId { get; set; }


       
     

    }
}
