using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class DeletionRestrictions
    {
        public long? Id { get; set; }
        public long? Restricted { get; set; }
        public string Ids { get; set; }
        public long? CheckType { get; set; }
        public long? Localize { get; set; }
        public long? LocStatus { get; set; }
        public string GateVersion { get; set; }
    }
}
