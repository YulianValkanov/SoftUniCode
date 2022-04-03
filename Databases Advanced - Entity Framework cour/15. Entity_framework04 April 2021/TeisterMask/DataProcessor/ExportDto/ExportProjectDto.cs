using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace TeisterMask.DataProcessor.ExportDto
{
    [XmlType("Project")]
    public class ExportProjectDto
    {
        [XmlElement("ProjectName")]
        public string Name { get; set; }

        [XmlAttribute("TasksCount")]
        public int TasksCount { get; set; }

        [XmlElement("HasEndDate")]
        public string HasEndDate { get; set; }

        [XmlArray("Tasks")]
        public ExportProjectTaskDto[] Tasks { get; set; }


        //      <Projects>
        //<Project TasksCount = "10" >
        //  < ProjectName > Hyster - Yale </ ProjectName >
        //  < HasEndDate > No </ HasEndDate >
        //  < Tasks >
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
