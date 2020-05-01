using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SubraceModels
{
    public class SubraceCreateModel
    {
        public string SubraceName { get; set; }
        public string SubraceDescription { get; set; }
        public string AbilityScoreIncrease { get; set; }
        public string SubraceSource { get; set; }
        public string SubraceOrigin { get; set; }
        public int RaceId { get; set; }
    }
}
