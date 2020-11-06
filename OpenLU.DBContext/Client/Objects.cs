using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class Objects
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public long? Placeable { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public long? Localize { get; set; }
        public long? NpcTemplateId { get; set; }
        public string DisplayName { get; set; }
        public double? InteractionDistance { get; set; }
        public long? Nametag { get; set; }
        public string InternalNotes { get; set; }
        public long? LocStatus { get; set; }
        public string GateVersion { get; set; }
        public long? HqValid { get; set; }
    }
}
