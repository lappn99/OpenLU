using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class Blueprints
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long? Accountid { get; set; }
        public long? Characterid { get; set; }
        public long? Price { get; set; }
        public long? Rating { get; set; }
        public long? Categoryid { get; set; }
        public string Lxfpath { get; set; }
        public long? Deleted { get; set; }
        public long? Created { get; set; }
        public long? Modified { get; set; }
    }
}
