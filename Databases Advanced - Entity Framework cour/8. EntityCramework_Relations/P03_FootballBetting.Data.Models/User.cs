using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    public class User
    {
        public User()
        {
            this.Bets = new HashSet<Bet>();
        }

        [Key]
        public int UserId { get; set; }

       
   

        [Required]
        public string Username { get; set; }

        //passward was stored Hash
        [Required]
        [MaxLength(256)]
        public int Password { get; set; }

        [Required]
        [MaxLength(75)]
        public string Email { get; set; }

        [Required]
        [MaxLength(75)]
        public string Name { get; set; }

        public decimal Balance { get; set; }

        public virtual ICollection<Bet> Bets { get; set; }
    }
}
