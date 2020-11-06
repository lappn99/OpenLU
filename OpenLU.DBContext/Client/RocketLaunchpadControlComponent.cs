using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class RocketLaunchpadControlComponent
    {
        public long? Id { get; set; }
        public long? TargetZone { get; set; }
        public long? DefaultZoneId { get; set; }
        public string TargetScene { get; set; }
        public long? GmLevel { get; set; }
        public string PlayerAnimation { get; set; }
        public string RocketAnimation { get; set; }
        public string LaunchMusic { get; set; }
        public long? UseLaunchPrecondition { get; set; }
        public long? UseAltLandingPrecondition { get; set; }
        public string LaunchPrecondition { get; set; }
        public string AltLandingPrecondition { get; set; }
        public string AltLandingSpawnPointName { get; set; }
    }
}
