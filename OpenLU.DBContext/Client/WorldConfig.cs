using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class WorldConfig
    {
        public long? WorldConfigId { get; set; }
        public double? Pegravityvalue { get; set; }
        public double? Pebroadphaseworldsize { get; set; }
        public double? Pegameobjscalefactor { get; set; }
        public double? CharacterRotationSpeed { get; set; }
        public double? CharacterWalkForwardSpeed { get; set; }
        public double? CharacterWalkBackwardSpeed { get; set; }
        public double? CharacterWalkStrafeSpeed { get; set; }
        public double? CharacterWalkStrafeForwardSpeed { get; set; }
        public double? CharacterWalkStrafeBackwardSpeed { get; set; }
        public double? CharacterRunBackwardSpeed { get; set; }
        public double? CharacterRunStrafeSpeed { get; set; }
        public double? CharacterRunStrafeForwardSpeed { get; set; }
        public double? CharacterRunStrafeBackwardSpeed { get; set; }
        public double? GlobalCooldown { get; set; }
        public double? CharacterGroundedTime { get; set; }
        public double? CharacterGroundedSpeed { get; set; }
        public double? GlobalImmunityTime { get; set; }
        public double? CharacterMaxSlope { get; set; }
        public double? Defaultrespawntime { get; set; }
        public double? MissionTooltipTimeout { get; set; }
        public double? VendorBuyMultiplier { get; set; }
        public double? PetFollowRadius { get; set; }
        public double? CharacterEyeHeight { get; set; }
        public double? FlightVerticalVelocity { get; set; }
        public double? FlightAirspeed { get; set; }
        public double? FlightFuelRatio { get; set; }
        public double? FlightMaxAirspeed { get; set; }
        public double? FReputationPerVote { get; set; }
        public long? NPropertyCloneLimit { get; set; }
        public long? DefaultHomespaceTemplate { get; set; }
        public double? CoinsLostOnDeathPercent { get; set; }
        public long? CoinsLostOnDeathMin { get; set; }
        public long? CoinsLostOnDeathMax { get; set; }
        public long? CharacterVotesPerDay { get; set; }
        public long? PropertyModerationRequestApprovalCost { get; set; }
        public long? PropertyModerationRequestReviewCost { get; set; }
        public long? PropertyModRequestsAllowedSpike { get; set; }
        public long? PropertyModRequestsAllowedInterval { get; set; }
        public long? PropertyModRequestsAllowedTotal { get; set; }
        public long? PropertyModRequestsSpikeDuration { get; set; }
        public long? PropertyModRequestsIntervalDuration { get; set; }
        public long? ModelModerateOnCreate { get; set; }
        public double? DefaultPropertyMaxHeight { get; set; }
        public double? ReputationPerVoteCast { get; set; }
        public double? ReputationPerVoteReceived { get; set; }
        public long? ShowcaseTopModelConsiderationBattles { get; set; }
        public double? ReputationPerBattlePromotion { get; set; }
        public double? CoinsLostOnDeathMinTimeout { get; set; }
        public double? CoinsLostOnDeathMaxTimeout { get; set; }
        public long? MailBaseFee { get; set; }
        public double? MailPercentAttachmentFee { get; set; }
        public long? PropertyReputationDelay { get; set; }
        public long? LevelCap { get; set; }
        public string LevelUpBehaviorEffect { get; set; }
        public long? CharacterVersion { get; set; }
        public long? LevelCapCurrencyConversion { get; set; }
    }
}
