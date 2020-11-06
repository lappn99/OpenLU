using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class BrickColors
    {
        public long? Id { get; set; }
        public double? Red { get; set; }
        public double? Green { get; set; }
        public double? Blue { get; set; }
        public double? Alpha { get; set; }
        public long? Legopaletteid { get; set; }
        public string Description { get; set; }
        public long? ValidTypes { get; set; }
        public long? ValidCharacters { get; set; }
        public long? FactoryValid { get; set; }
    }
}
