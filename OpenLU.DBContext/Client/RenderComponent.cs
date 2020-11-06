using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class RenderComponent
    {
        public long? Id { get; set; }
        public string RenderAsset { get; set; }
        public string IconAsset { get; set; }
        public long? IconId { get; set; }
        public long? ShaderId { get; set; }
        public long? Effect1 { get; set; }
        public long? Effect2 { get; set; }
        public long? Effect3 { get; set; }
        public long? Effect4 { get; set; }
        public long? Effect5 { get; set; }
        public long? Effect6 { get; set; }
        public string AnimationGroupIds { get; set; }
        public long? Fade { get; set; }
        public long? Usedropshadow { get; set; }
        public long? PreloadAnimations { get; set; }
        public double? FadeInTime { get; set; }
        public double? MaxShadowDistance { get; set; }
        public long? IgnoreCameraCollision { get; set; }
        public long? RenderComponentLod1 { get; set; }
        public long? RenderComponentLod2 { get; set; }
        public long? GradualSnap { get; set; }
        public long? AnimationFlag { get; set; }
        public string AudioMetaEventSet { get; set; }
        public double? BillboardHeight { get; set; }
        public double? ChatBubbleOffset { get; set; }
        public long? StaticBillboard { get; set; }
        public string Lxfmlfolder { get; set; }
        public long? AttachIndicatorsToNode { get; set; }
    }
}
