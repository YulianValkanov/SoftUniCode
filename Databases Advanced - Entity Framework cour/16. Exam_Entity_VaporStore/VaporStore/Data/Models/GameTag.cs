﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VaporStore.Data.Models
{
    public class GameTag
    {
       
        [ForeignKey("Game")]
        [Required]
        public int GameId { get; set; }

        public Game Game { get; set; }

        [ForeignKey("Tag")]
        [Required]
        public int TagId { get; set; }

        public Tag Tag { get; set; }



        //        GameTag
        //•	GameId – integer, Primary Key, foreign key(required)
        //•	Game – Game
        //•	TagId – integer, Primary Key, foreign key(required)
        //•	Tag – Tag

    }
}