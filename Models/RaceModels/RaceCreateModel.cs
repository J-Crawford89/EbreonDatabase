using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RaceModels
{
    public class RaceCreateModel
    {
        public string RaceName { get; set; }
        public string RaceDescription { get; set; }
        public string AbilityScoreIncrease { get; set; }
        public string Speed { get; set; }
        public string Language { get; set; }
        public bool Darkvision { get; set; }
        public string Source { get; set; }
        public string Origin { get; set; }
    }
}
