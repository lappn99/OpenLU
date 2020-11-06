using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class PackageComponent
    {
        public long? Id { get; set; }
        public long? LootMatrixIndex { get; set; }
        public long? PackageType { get; set; }
    }
}
