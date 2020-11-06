using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class ZoneLoadingTips
    {
        public long? Id { get; set; }
        public long? Zoneid { get; set; }
        public string Imagelocation { get; set; }
        public long? Localize { get; set; }
        public string GateVersion { get; set; }
        public long? LocStatus { get; set; }
        public long? Weight { get; set; }
        public string TargetVersion { get; set; }
    }
}
