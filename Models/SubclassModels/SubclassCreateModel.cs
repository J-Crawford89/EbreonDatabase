using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SubclassModels
{
    public class SubclassCreateModel
    {
        public string SubclassName { get; set; }
        public string SubclassDescription { get; set; }
        public string Source { get; set; }
        public int ClassId { get; set; }
    }
}
