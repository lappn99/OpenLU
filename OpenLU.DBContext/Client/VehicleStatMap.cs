using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class VehicleStatMap
    {
        public long? Id { get; set; }
        public string ModuleStat { get; set; }
        public string HavokStat { get; set; }
        public double? HavokChangePerModuleStat { get; set; }
    }
}
