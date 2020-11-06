using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class PhysicsComponent
    {
        public long? Id { get; set; }
        public double? Static { get; set; }
        public string PhysicsAsset { get; set; }
        public double? Jump { get; set; }
        public double? Doublejump { get; set; }
        public double? Speed { get; set; }
        public double? RotSpeed { get; set; }
        public double? PlayerHeight { get; set; }
        public double? PlayerRadius { get; set; }
        public long? PcShapeType { get; set; }
        public long? CollisionGroup { get; set; }
        public double? AirSpeed { get; set; }
        public string BoundaryAsset { get; set; }
        public double? JumpAirSpeed { get; set; }
        public double? Friction { get; set; }
        public string GravityVolumeAsset { get; set; }
    }
}
