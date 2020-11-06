using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class MapAssetType
    {
        public long? Id { get; set; }
        public string Label { get; set; }
        public string Pathdir { get; set; }
        public string Typelabel { get; set; }
    }
}
