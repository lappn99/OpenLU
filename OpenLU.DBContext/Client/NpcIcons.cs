using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class NpcIcons
    {
        public long? Id { get; set; }
        public long? Color { get; set; }
        public double? Offset { get; set; }
        public long? Lot { get; set; }
        public string Texture { get; set; }
        public long? IsClickable { get; set; }
        public double? Scale { get; set; }
        public long? RotateToFace { get; set; }
        public double? CompositeHorizOffset { get; set; }
        public double? CompositeVertOffset { get; set; }
        public double? CompositeScale { get; set; }
        public string CompositeConnectionNode { get; set; }
        public long? CompositeLotmultiMission { get; set; }
        public long? CompositeLotmultiMissionVentor { get; set; }
        public string CompositeIconTexture { get; set; }
    }
}
