using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class WhatsCoolItemSpotlight
    {
        public long? Id { get; set; }
        public long? ItemId { get; set; }
        public long? Localize { get; set; }
        public string GateVersion { get; set; }
        public long? LocStatus { get; set; }
    }
}
