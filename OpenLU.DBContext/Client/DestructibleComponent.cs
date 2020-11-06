using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class DestructibleComponent
    {
        public long? Id { get; set; }
        public long? Faction { get; set; }
        public string FactionList { get; set; }
        public long? Life { get; set; }
        public long? Imagination { get; set; }
        public long? LootMatrixIndex { get; set; }
        public long? CurrencyIndex { get; set; }
        public long? Level { get; set; }
        public double? Armor { get; set; }
        public long? DeathBehavior { get; set; }
        public long? Isnpc { get; set; }
        public long? AttackPriority { get; set; }
        public long? IsSmashable { get; set; }
        public long? DifficultyLevel { get; set; }
    }
}
