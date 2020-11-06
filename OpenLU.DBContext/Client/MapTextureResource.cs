using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class MapTextureResource
    {
        public long? Id { get; set; }
        public string Texturepath { get; set; }
        public long? SurfaceType { get; set; }
    }
}
