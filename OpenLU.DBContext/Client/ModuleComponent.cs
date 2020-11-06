using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class ModuleComponent
    {
        public long? Id { get; set; }
        public long? PartCode { get; set; }
        public long? BuildType { get; set; }
        public string Xml { get; set; }
        public string PrimarySoundGuid { get; set; }
        public long? AssembledEffectId { get; set; }
    }
}
