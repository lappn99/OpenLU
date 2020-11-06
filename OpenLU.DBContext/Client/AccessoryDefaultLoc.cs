using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class AccessoryDefaultLoc
    {
        public long? GroupId { get; set; }
        public string Description { get; set; }
        public double? PosX { get; set; }
        public double? PosY { get; set; }
        public double? PosZ { get; set; }
        public double? RotX { get; set; }
        public double? RotY { get; set; }
        public double? RotZ { get; set; }
    }
}
