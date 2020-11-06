using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class EventGating
    {
        public string EventName { get; set; }
        public long? DateStart { get; set; }
        public long? DateEnd { get; set; }
    }
}
