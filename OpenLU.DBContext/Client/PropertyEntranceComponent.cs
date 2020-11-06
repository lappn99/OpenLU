using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class PropertyEntranceComponent
    {
        public long? Id { get; set; }
        public long? MapId { get; set; }
        public string PropertyName { get; set; }
        public long? IsOnProperty { get; set; }
        public string GroupType { get; set; }
    }
}
