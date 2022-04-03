using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;
using TeisterMask.Common;

namespace TeisterMask.DataProcessor.ImportDto
{
    [XmlType("Project")]
    public class ImportProjectDto
    {
        [XmlElement("Name")]
        [Required]
        [MaxLength(GlobalConstants.PROJECT_NAME_MAX)]
        [MinLength(GlobalConstants.PROJECT_NAME_MIN)]
        public string Name { get; set; }

        [XmlElement("OpenDate")]
        [Required]
        public string OpenDate { get; set; }

        [XmlElement("DueDate")]
        public string DueDate { get; set; }

        [XmlArray("Tasks")]
        public ImportProjectTaskDto[] Tasks { get; set; }





        //    <Project>
        //<Name>S</Name>
        //<OpenDate>25/01/2018</OpenDate>
        //<DueDate>16/08/2019</DueDate>
        //<Tasks>
        //  <Task>
        //    <Name>Australian</Name>
        //    <OpenDate>19/08/2018</OpenDate>
        //    <DueDate>13/07/2019</DueDate>
        //    <ExecutionType>2</ExecutionType>
        //    <LabelType>0</LabelType>
        //  </Task>
    }
}
