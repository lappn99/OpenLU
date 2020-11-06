using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class RenderComponentFlash
    {
        public long? Id { get; set; }
        public long? Interactive { get; set; }
        public long? Animated { get; set; }
        public string NodeName { get; set; }
        public string FlashPath { get; set; }
        public string ElementName { get; set; }
        public long? Uid { get; set; }
    }
}
