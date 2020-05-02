using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RaceModels
{
    public class RaceUpdateModel
    {
        public string UpdatedRaceName { get; set; }
        public string UpdatedRaceDescription { get; set; }
        public bool? UpdatedHasSubraces { get; set; }
        public string UpdatedSpeed { get; set; }
        public string UpdatedLanguage { get; set; }
        public string UpdatedAbilityScoreIncrease { get; set; }
        public bool? UpdatedHasDarkvision { get; set; }
        public string UpdatedSource { get; set; }
        public string UpdatedOrigin { get; set; }
    }
}
