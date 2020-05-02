using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SubraceModels
{
    public class SubraceDetailModel
    {
        public int SubraceId { get; set; }
        public string SubraceName { get; set; }
        public string SubraceDescription { get; set; }
        public string AbilityScoreIncrease { get; set; }
        public string Source { get; set; }
        public string Origin { get; set; }
        public string ParentRaceName { get; set; }
    }
}
