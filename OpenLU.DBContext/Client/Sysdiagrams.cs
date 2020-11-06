using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class Sysdiagrams
    {
        public string Name { get; set; }
        public long? PrincipalId { get; set; }
        public long? DiagramId { get; set; }
        public long? Version { get; set; }
        public string Definition { get; set; }
    }
}
