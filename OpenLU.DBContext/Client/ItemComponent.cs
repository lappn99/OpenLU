using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class ItemComponent
    {
        public long? Id { get; set; }
        public string EquipLocation { get; set; }
        public long? BaseValue { get; set; }
        public long? IsKitPiece { get; set; }
        public long? Rarity { get; set; }
        public long? ItemType { get; set; }
        public long? ItemInfo { get; set; }
        public long? InLootTable { get; set; }
        public long? InVendor { get; set; }
        public long? IsUnique { get; set; }
        public long? IsBop { get; set; }
        public long? IsBoe { get; set; }
        public long? ReqFlagId { get; set; }
        public long? ReqSpecialtyId { get; set; }
        public long? ReqSpecRank { get; set; }
        public long? ReqAchievementId { get; set; }
        public long? StackSize { get; set; }
        public long? Color1 { get; set; }
        public long? Decal { get; set; }
        public long? OffsetGroupId { get; set; }
        public long? BuildTypes { get; set; }
        public string ReqPrecondition { get; set; }
        public long? AnimationFlag { get; set; }
        public long? EquipEffects { get; set; }
        public long? ReadyForQa { get; set; }
        public long? ItemRating { get; set; }
        public long? IsTwoHanded { get; set; }
        public long? MinNumRequired { get; set; }
        public long? DelResIndex { get; set; }
        public long? CurrencyLot { get; set; }
        public long? AltCurrencyCost { get; set; }
        public string SubItems { get; set; }
        public string AudioEventUse { get; set; }
        public long? NoEquipAnimation { get; set; }
        public long? CommendationLot { get; set; }
        public long? CommendationCost { get; set; }
        public string AudioEquipMetaEventSet { get; set; }
        public string CurrencyCosts { get; set; }
        public string IngredientInfo { get; set; }
        public long? LocStatus { get; set; }
        public long? ForgeType { get; set; }
        public double? SellMultiplier { get; set; }
    }
}
