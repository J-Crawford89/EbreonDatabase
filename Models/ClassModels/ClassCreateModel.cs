using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Models.ClassModels
{
    public class ClassCreateModel
    {
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public string KeyAbilities { get; set; }
        public string Source { get; set; }
    }
}
