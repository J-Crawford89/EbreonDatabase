using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Race
    {
        [Key]
        public int RaceId { get; set; }
        public string RaceName { get; set; }
        public string RaceDescription { get; set; }
        public string Speed { get; set; }
        public string Language { get; set; }
        public string AbilityScoreIncrease { get; set; }
        public bool Darkvision { get; set; }
        public string Origin { get; set; }
        public string Source { get; set; }
    }
}
