using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SubraceModels
{
    public class SubraceUpdateModel
    {
        public int SubraceId { get; set; }
        public string UpdatedSubraceName { get; set; }
        public string UpdatedSubraceDescription { get; set; }
        public string UpdatedAbilityScoreIncrease { get; set; }
        public string UpdatedSource { get; set; }
        public string UpdatedOrigin { get; set; }
        public int? UpdatedRaceId { get; set; }
    }
}
