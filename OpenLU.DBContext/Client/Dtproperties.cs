using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class Dtproperties
    {
        public long? Id { get; set; }
        public long? Objectid { get; set; }
        public string Property { get; set; }
        public string Value { get; set; }
        public string Uvalue { get; set; }
        public byte[] Lvalue { get; set; }
        public long? Version { get; set; }
    }
}
