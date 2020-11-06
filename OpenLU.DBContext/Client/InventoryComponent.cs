using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class InventoryComponent
    {
        public long? Id { get; set; }
        public long? Itemid { get; set; }
        public long? Count { get; set; }
        public long? Equip { get; set; }
    }
}
