using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class Emotes
    {
        public long? Id { get; set; }
        public string AnimationName { get; set; }
        public string IconFilename { get; set; }
        public string Channel { get; set; }
        public string Command { get; set; }
        public long? Locked { get; set; }
        public long? Localize { get; set; }
        public long? LocStatus { get; set; }
        public string GateVersion { get; set; }
    }
}
