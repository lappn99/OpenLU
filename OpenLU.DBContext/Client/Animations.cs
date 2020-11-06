using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class Animations
    {
        public long? AnimationGroupId { get; set; }
        public string AnimationType { get; set; }
        public string AnimationName { get; set; }
        public double? ChanceToPlay { get; set; }
        public long? MinLoops { get; set; }
        public long? MaxLoops { get; set; }
        public double? AnimationLength { get; set; }
        public long? HideEquip { get; set; }
        public long? IgnoreUpperBody { get; set; }
        public long? Restartable { get; set; }
        public string FaceAnimationName { get; set; }
        public double? Priority { get; set; }
        public double? BlendTime { get; set; }
    }
}
