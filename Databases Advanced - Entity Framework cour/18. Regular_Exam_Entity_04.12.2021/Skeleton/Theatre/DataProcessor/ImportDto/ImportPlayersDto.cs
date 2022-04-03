using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;
using Theatre.Data.Models.Enums;

namespace Theatre.DataProcessor.ImportDto
{
    [XmlType("Play")]
    public class ImportPlayersDto
    {
        [XmlElement("Title")]
        [MinLength(4)]
        [MaxLength(50)]
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// CHECK WORKING min Lenght
        /// </summary>
        
        [XmlElement("Duration")]
        [Required]
       // [MinLength(1)]
        public string Duration { get; set; }

        /// <summary>
        /// CHECK FLOAT FORMAT
        /// </summary>
       [XmlElement("Rating")]
        [Required]
        [Range(0.00, 10.00)]
        public float Rating { get; set; }

        [XmlElement("Genre")]
        [Required]
        public string Genre { get; set; }

        [XmlElement("Description")]
        [MaxLength(700)]
        [Required]
        public string Description { get; set; }

        [XmlElement("Screenwriter")]
        [MinLength(4)]
        [MaxLength(30)]
        [Required]
        public string Screenwriter { get; set; }




    }

  //  <Plays>
  //<Play>
  //  <Title>The Hsdfoming</Title>
  //  <Duration>03:40:00</Duration>
  //  <Rating>8.2</Rating>
  //  <Genre>Action</Genre>
  //  <Description>A guyat Pinter turns into a debatable conundrum as oth ordinary and menacing.
    //Much of this has to do with the fabled Pinter Pause, which simply mirrors the way we often 
    //respond to each other in conversation, tossing in remainders of thoughts on one subject well after having moved on to another.</Description>

  //  <Screenwriter>Roger Nciotti</Screenwriter>
  //</Play>
  //<Play>
}
