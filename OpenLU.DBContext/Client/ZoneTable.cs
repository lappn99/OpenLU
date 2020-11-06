using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class ZoneTable
    {
        public long? ZoneId { get; set; }
        public long? LocStatus { get; set; }
        public string ZoneName { get; set; }
        public long? ScriptId { get; set; }
        public double? GhostdistanceMin { get; set; }
        public double? Ghostdistance { get; set; }
        public long? PopulationSoftCap { get; set; }
        public long? PopulationHardCap { get; set; }
        public string DisplayDescription { get; set; }
        public string MapFolder { get; set; }
        public double? SmashableMinDistance { get; set; }
        public double? SmashableMaxDistance { get; set; }
        public string MixerProgram { get; set; }
        public string ClientPhysicsFramerate { get; set; }
        public string ServerPhysicsFramerate { get; set; }
        public long? ZoneControlTemplate { get; set; }
        public long? WidthInChunks { get; set; }
        public long? HeightInChunks { get; set; }
        public long? PetsAllowed { get; set; }
        public long? Localize { get; set; }
        public double? FZoneWeight { get; set; }
        public string Thumbnail { get; set; }
        public long? PlayerLoseCoinsOnDeath { get; set; }
        public long? DisableSaveLoc { get; set; }
        public double? TeamRadius { get; set; }
        public string GateVersion { get; set; }
        public long? MountsAllowed { get; set; }
    }
}
