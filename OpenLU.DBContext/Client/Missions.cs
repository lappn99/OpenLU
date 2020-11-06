using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class Missions
    {
        public long? Id { get; set; }
        public string DefinedType { get; set; }
        public string DefinedSubtype { get; set; }
        public long? UisortOrder { get; set; }
        public long? OfferObjectId { get; set; }
        public long? TargetObjectId { get; set; }
        public long? RewardCurrency { get; set; }
        public long? LegoScore { get; set; }
        public long? RewardReputation { get; set; }
        public long? IsChoiceReward { get; set; }
        public long? RewardItem1 { get; set; }
        public long? RewardItem1Count { get; set; }
        public long? RewardItem2 { get; set; }
        public long? RewardItem2Count { get; set; }
        public long? RewardItem3 { get; set; }
        public long? RewardItem3Count { get; set; }
        public long? RewardItem4 { get; set; }
        public long? RewardItem4Count { get; set; }
        public long? RewardEmote { get; set; }
        public long? RewardEmote2 { get; set; }
        public long? RewardEmote3 { get; set; }
        public long? RewardEmote4 { get; set; }
        public long? RewardMaximagination { get; set; }
        public long? RewardMaxhealth { get; set; }
        public long? RewardMaxinventory { get; set; }
        public long? RewardMaxmodel { get; set; }
        public long? RewardMaxwidget { get; set; }
        public long? RewardMaxwallet { get; set; }
        public long? Repeatable { get; set; }
        public long? RewardCurrencyRepeatable { get; set; }
        public long? RewardItem1Repeatable { get; set; }
        public long? RewardItem1RepeatCount { get; set; }
        public long? RewardItem2Repeatable { get; set; }
        public long? RewardItem2RepeatCount { get; set; }
        public long? RewardItem3Repeatable { get; set; }
        public long? RewardItem3RepeatCount { get; set; }
        public long? RewardItem4Repeatable { get; set; }
        public long? RewardItem4RepeatCount { get; set; }
        public long? TimeLimit { get; set; }
        public long? IsMission { get; set; }
        public long? MissionIconId { get; set; }
        public string PrereqMissionId { get; set; }
        public long? Localize { get; set; }
        public long? InMotd { get; set; }
        public long? CooldownTime { get; set; }
        public long? IsRandom { get; set; }
        public string RandomPool { get; set; }
        public long? UiprereqId { get; set; }
        public string GateVersion { get; set; }
        public string Hudstates { get; set; }
        public long? LocStatus { get; set; }
        public long? RewardBankinventory { get; set; }
    }
}
