using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;
using TeisterMask.Common;

namespace TeisterMask.DataProcessor.ImportDto
{
    [XmlType("Task")]
    public class ImportProjectTaskDto
    {

        [XmlElement("Name")]
        [Required]
        [MaxLength(GlobalConstants.TASK_NAME_MAX)]
        [MinLength(GlobalConstants.TASK_NAME_MIN)]
        public string Name { get; set; }

        [XmlElement("OpenDate")]
        [Required]
        public string TaskOpenDate { get; set; }

        [XmlElement("DueDate")]
        [Required]
        public string TaskDueDate { get; set; }

        [XmlElement("ExecutionType")]
        [Range(GlobalConstants.EXECUTION_TYPE_MIN,GlobalConstants.EXECUTION_TYPE_MAX)]
        public int ExecutionType { get; set; }

        [XmlElement("LabelType")]
        [Range(GlobalConstants.LABLE_TYPE_MIN,GlobalConstants.LABLE_TYPE_MAX)]
        public int LabelType { get; set; }




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
