using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class BrickAttributes
    {
        public long? Id { get; set; }
        public string IconAsset { get; set; }
        public long? DisplayOrder { get; set; }
        public long? LocStatus { get; set; }
    }
}
