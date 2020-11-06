using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class TrailEffects
    {
        public long? TrailId { get; set; }
        public string TextureName { get; set; }
        public long? Blendmode { get; set; }
        public double? Cardlifetime { get; set; }
        public double? Colorlifetime { get; set; }
        public double? MinTailFade { get; set; }
        public double? TailFade { get; set; }
        public long? MaxParticles { get; set; }
        public double? BirthDelay { get; set; }
        public double? DeathDelay { get; set; }
        public string Bone1 { get; set; }
        public string Bone2 { get; set; }
        public double? TexLength { get; set; }
        public double? TexWidth { get; set; }
        public double? StartColorR { get; set; }
        public double? StartColorG { get; set; }
        public double? StartColorB { get; set; }
        public double? StartColorA { get; set; }
        public double? MiddleColorR { get; set; }
        public double? MiddleColorG { get; set; }
        public double? MiddleColorB { get; set; }
        public double? MiddleColorA { get; set; }
        public double? EndColorR { get; set; }
        public double? EndColorG { get; set; }
        public double? EndColorB { get; set; }
        public double? EndColorA { get; set; }
    }
}
