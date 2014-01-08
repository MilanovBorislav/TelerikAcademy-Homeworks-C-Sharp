using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    [AttributeUsageAttribute(AttributeTargets.Struct |
        AttributeTargets.Class|AttributeTargets.Interface|
        AttributeTargets.Method|AttributeTargets.Enum
        ,AllowMultiple= false)]

    public class VersionAttribute :System.Attribute
    {
        public string Version{get; private set;}

        public VersionAttribute(string version)
        {
           this.Version = version;
        }

    }
}
