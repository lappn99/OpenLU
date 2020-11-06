using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class BuffParameters
    {
        public long? BuffId { get; set; }
        public string ParameterName { get; set; }
        public double? NumberValue { get; set; }
        public string StringValue { get; set; }
        public long? EffectId { get; set; }
    }
}
