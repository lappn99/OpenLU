using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class BehaviorParameter
    {
        public long? BehaviorId { get; set; }
        public string ParameterId { get; set; }
        public double? Value { get; set; }
    }
}
