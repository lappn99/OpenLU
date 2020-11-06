using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class ProximityMonitorComponent
    {
        public long? Id { get; set; }
        public string Proximities { get; set; }
        public long? LoadOnClient { get; set; }
        public long? LoadOnServer { get; set; }
    }
}
