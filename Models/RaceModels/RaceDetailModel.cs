using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RaceModels
{
    public class RaceDetailModel
    {
        public int RaceId { get; set; }
        public string RaceName { get; set; }
        public string RaceDescription { get; set; }
        public bool HasSubraces { get; set; }
        public string Speed { get; set; }
        public string AbilityScoreIncrease { get; set; }
        public string Language { get; set; }
        public bool HasDarkvision { get; set; }
        public string Source { get; set; }
        public string Origin { get; set; }
    }
}
