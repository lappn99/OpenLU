using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class BehaviorTemplate
    {
        public long? BehaviorId { get; set; }
        public long? TemplateId { get; set; }
        public long? EffectId { get; set; }
        public string EffectHandle { get; set; }
    }
}
