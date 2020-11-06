using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class CelebrationParameters
    {
        public long? Id { get; set; }
        public string Animation { get; set; }
        public long? BackgroundObject { get; set; }
        public double? Duration { get; set; }
        public string SubText { get; set; }
        public string MainText { get; set; }
        public long? IconId { get; set; }
        public double? CeleLeadIn { get; set; }
        public double? CeleLeadOut { get; set; }
        public long? CameraPathLot { get; set; }
        public string PathNodeName { get; set; }
        public double? AmbientR { get; set; }
        public double? AmbientG { get; set; }
        public double? AmbientB { get; set; }
        public double? DirectionalR { get; set; }
        public double? DirectionalG { get; set; }
        public double? DirectionalB { get; set; }
        public double? SpecularR { get; set; }
        public double? SpecularG { get; set; }
        public double? SpecularB { get; set; }
        public double? LightPositionX { get; set; }
        public double? LightPositionY { get; set; }
        public double? LightPositionZ { get; set; }
        public double? BlendTime { get; set; }
        public double? FogColorR { get; set; }
        public double? FogColorG { get; set; }
        public double? FogColorB { get; set; }
        public string MusicCue { get; set; }
        public string SoundGuid { get; set; }
        public string MixerProgram { get; set; }
    }
}
