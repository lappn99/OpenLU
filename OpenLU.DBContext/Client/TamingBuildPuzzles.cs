using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class TamingBuildPuzzles
    {
        public long? Id { get; set; }
        public long? PuzzleModelLot { get; set; }
        public long? Npclot { get; set; }
        public string ValidPiecesLxf { get; set; }
        public string InvalidPiecesLxf { get; set; }
        public long? Difficulty { get; set; }
        public long? Timelimit { get; set; }
        public long? NumValidPieces { get; set; }
        public long? TotalNumPieces { get; set; }
        public string ModelName { get; set; }
        public string FullModelLxf { get; set; }
        public double? Duration { get; set; }
        public long? ImagCostPerBuild { get; set; }
    }
}
