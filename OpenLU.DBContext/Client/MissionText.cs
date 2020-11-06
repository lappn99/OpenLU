using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class MissionText
    {
        public long? Id { get; set; }
        public string StoryIcon { get; set; }
        public string MissionIcon { get; set; }
        public string OfferNpcicon { get; set; }
        public long? IconId { get; set; }
        public string State1Anim { get; set; }
        public string State2Anim { get; set; }
        public string State3Anim { get; set; }
        public string State4Anim { get; set; }
        public string State3TurninAnim { get; set; }
        public string State4TurninAnim { get; set; }
        public string OnclickAnim { get; set; }
        public string CinematicAccepted { get; set; }
        public double? CinematicAcceptedLeadin { get; set; }
        public string CinematicCompleted { get; set; }
        public double? CinematicCompletedLeadin { get; set; }
        public string CinematicRepeatable { get; set; }
        public double? CinematicRepeatableLeadin { get; set; }
        public string CinematicRepeatableCompleted { get; set; }
        public double? CinematicRepeatableCompletedLeadin { get; set; }
        public string AudioEventGuidInteract { get; set; }
        public string AudioEventGuidOfferAccept { get; set; }
        public string AudioEventGuidOfferDeny { get; set; }
        public string AudioEventGuidCompleted { get; set; }
        public string AudioEventGuidTurnIn { get; set; }
        public string AudioEventGuidFailed { get; set; }
        public string AudioEventGuidProgress { get; set; }
        public string AudioMusicCueOfferAccept { get; set; }
        public string AudioMusicCueTurnIn { get; set; }
        public long? TurnInIconId { get; set; }
        public long? Localize { get; set; }
        public long? LocStatus { get; set; }
        public string GateVersion { get; set; }
    }
}
