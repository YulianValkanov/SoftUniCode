

namespace P03_FootballBetting.Data.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Color
    {
        [Key]
        public int ColorId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [InverseProperty("PrimaryKitColor")]
        public virtual ICollection<Team> PrimaryKitTeams { get; set; }

        [InverseProperty("SecondaryKitColor")]
        public virtual ICollection<Team> SeconcaryKitTeams { get; set; }
    }
}
