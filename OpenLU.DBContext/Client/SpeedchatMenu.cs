using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class SpeedchatMenu
    {
        public long? Id { get; set; }
        public long? ParentId { get; set; }
        public long? EmoteId { get; set; }
        public string ImageName { get; set; }
        public long? Localize { get; set; }
        public long? LocStatus { get; set; }
        public string GateVersion { get; set; }
    }
}
