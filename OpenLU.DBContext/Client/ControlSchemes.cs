using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class ControlSchemes
    {
        public long? ControlScheme { get; set; }
        public string SchemeName { get; set; }
        public double? RotationSpeed { get; set; }
        public double? WalkForwardSpeed { get; set; }
        public double? WalkBackwardSpeed { get; set; }
        public double? WalkStrafeSpeed { get; set; }
        public double? WalkStrafeForwardSpeed { get; set; }
        public double? WalkStrafeBackwardSpeed { get; set; }
        public double? RunBackwardSpeed { get; set; }
        public double? RunStrafeSpeed { get; set; }
        public double? RunStrafeForwardSpeed { get; set; }
        public double? RunStrafeBackwardSpeed { get; set; }
        public double? KeyboardZoomSensitivity { get; set; }
        public double? KeyboardPitchSensitivity { get; set; }
        public double? KeyboardYawSensitivity { get; set; }
        public double? MouseZoomWheelSensitivity { get; set; }
        public double? XMouseMoveSensitivityModifier { get; set; }
        public double? YMouseMoveSensitivityModifier { get; set; }
        public double? FreecamSpeedModifier { get; set; }
        public double? FreecamSlowSpeedMultiplier { get; set; }
        public double? FreecamFastSpeedMultiplier { get; set; }
        public double? FreecamMouseModifier { get; set; }
        public double? GamepadPitchRotSensitivity { get; set; }
        public double? GamepadYawRotSensitivity { get; set; }
        public double? GamepadTriggerSensitivity { get; set; }
    }
}
