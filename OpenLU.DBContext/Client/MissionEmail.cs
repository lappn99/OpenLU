using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class MissionEmail
    {
        public long? Id { get; set; }
        public long? MessageType { get; set; }
        public long? NotificationGroup { get; set; }
        public long? MissionId { get; set; }
        public long? AttachmentLot { get; set; }
        public long? Localize { get; set; }
        public long? LocStatus { get; set; }
        public string GateVersion { get; set; }
    }
}
