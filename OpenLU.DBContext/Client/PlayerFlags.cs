using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class PlayerFlags
    {
        public long? Id { get; set; }
        public long? SessionOnly { get; set; }
        public long? OnlySetByServer { get; set; }
        public long? SessionZoneOnly { get; set; }
    }
}
