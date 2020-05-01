using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SubclassModels
{
    public class SubclassUpdateModel
    {
        public string UpdatedSubclassName { get; set; }
        public string UpdatedSubclassDescription { get; set; }
        public string UpdatedSource { get; set; }
        public int? UpdatedClassId { get; set; }
    }
}
