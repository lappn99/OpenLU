using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class MinifigDecalsTorsos
    {
        public long? Id { get; set; }
        public string HighPath { get; set; }
        public long? CharacterCreateValid { get; set; }
        public long? Male { get; set; }
        public long? Female { get; set; }
    }
}
