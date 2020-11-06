using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class RewardCodes
    {
        public long? Id { get; set; }
        public string Code { get; set; }
        public long? AttachmentLot { get; set; }
        public long? LocStatus { get; set; }
        public string GateVersion { get; set; }
    }
}
