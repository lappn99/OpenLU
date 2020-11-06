using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class Factions
    {
        public long? Faction { get; set; }
        public string FactionList { get; set; }
        public long? FactionListFriendly { get; set; }
        public string FriendList { get; set; }
        public string EnemyList { get; set; }
    }
}
