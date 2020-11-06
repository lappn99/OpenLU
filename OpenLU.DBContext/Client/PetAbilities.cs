using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class PetAbilities
    {
        public long? Id { get; set; }
        public string AbilityName { get; set; }
        public long? ImaginationCost { get; set; }
        public long? LocStatus { get; set; }
    }
}
