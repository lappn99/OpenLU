using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class BehaviorEffect
    {
        public long? EffectId { get; set; }
        public string EffectType { get; set; }
        public string EffectName { get; set; }
        public long? TrailId { get; set; }
        public double? PcreateDuration { get; set; }
        public string AnimationName { get; set; }
        public long? AttachToObject { get; set; }
        public string BoneName { get; set; }
        public long? UseSecondary { get; set; }
        public long? CameraEffectType { get; set; }
        public double? CameraDuration { get; set; }
        public double? CameraFrequency { get; set; }
        public double? CameraXamp { get; set; }
        public double? CameraYamp { get; set; }
        public double? CameraZamp { get; set; }
        public double? CameraRotFrequency { get; set; }
        public double? CameraRoll { get; set; }
        public double? CameraPitch { get; set; }
        public double? CameraYaw { get; set; }
        public string AudioEventGuid { get; set; }
        public long? RenderEffectType { get; set; }
        public double? RenderEffectTime { get; set; }
        public double? RenderStartVal { get; set; }
        public double? RenderEndVal { get; set; }
        public double? RenderDelayVal { get; set; }
        public double? RenderValue1 { get; set; }
        public double? RenderValue2 { get; set; }
        public double? RenderValue3 { get; set; }
        public string RenderRgba { get; set; }
        public long? RenderShaderVal { get; set; }
        public long? MotionId { get; set; }
        public long? MeshId { get; set; }
        public double? MeshDuration { get; set; }
        public string MeshLockedNode { get; set; }
    }
}
