using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class TextLanguage
    {
        public long? TextId { get; set; }
        public long? LanguageId { get; set; }
        public string Text { get; set; }
    }
}
