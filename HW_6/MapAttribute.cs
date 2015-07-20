using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Property, AllowMultiple = true)]
    class MapAttribute : System.Attribute
    {
        public string mappingClassName { get; set; }
        public string mappingFiledName { get; set; }
    }
}
