using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class MissionNpccomponent
    {
        public long? Id { get; set; }
        public long? MissionId { get; set; }
        public long? OffersMission { get; set; }
        public long? AcceptsMission { get; set; }
        public string GateVersion { get; set; }
    }
}
