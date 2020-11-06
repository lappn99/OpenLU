using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class JetPackPadComponent
    {
        public long? Id { get; set; }
        public double? XDistance { get; set; }
        public double? YDistance { get; set; }
        public double? WarnDistance { get; set; }
        public long? LotBlocker { get; set; }
        public long? LotWarningVolume { get; set; }
    }
}
