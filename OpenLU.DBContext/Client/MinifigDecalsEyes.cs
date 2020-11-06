using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class MinifigDecalsEyes
    {
        public long? Id { get; set; }
        public string HighPath { get; set; }
        public string LowPath { get; set; }
        public long? CharacterCreateValid { get; set; }
        public long? Male { get; set; }
        public long? Female { get; set; }
    }
}
