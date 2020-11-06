using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class ScriptComponent
    {
        public long? Id { get; set; }
        public string ScriptName { get; set; }
        public string ClientScriptName { get; set; }
    }
}
