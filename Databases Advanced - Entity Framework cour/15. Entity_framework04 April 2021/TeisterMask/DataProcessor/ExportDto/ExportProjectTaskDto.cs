using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace TeisterMask.DataProcessor.ExportDto
{
    [XmlType("Task")]
    public class ExportProjectTaskDto
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Label")]
        public string LabelString { get; set; }





        //  /  < Tasks >
        //    < Task >
        //      < Name > Broadleaf </ Name >
        //      < Label > JavaAdvanced </ Label >
        //    </ Task >
        //    < Task >
        //      < Name > Bryum </ Name >
        //      < Label > EntityFramework </ Label >
        //    </ Task >

    }
}
