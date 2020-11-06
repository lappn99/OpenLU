using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class Camera
    {
        public string CameraName { get; set; }
        public double? PitchAngleTolerance { get; set; }
        public double? StartingZoom { get; set; }
        public double? ZoomReturnModifier { get; set; }
        public double? PitchReturnModifier { get; set; }
        public double? TetherOutReturnModifier { get; set; }
        public double? TetherInReturnMultiplier { get; set; }
        public double? VerticleMovementDampeningModifier { get; set; }
        public double? ReturnFromInclineModifier { get; set; }
        public double? HorizontalReturnModifier { get; set; }
        public double? YawBehaviorSpeedMultiplier { get; set; }
        public double? CameraCollisionPadding { get; set; }
        public double? GlideSpeed { get; set; }
        public double? FadePlayerMinRange { get; set; }
        public double? MinMovementDeltaTolerance { get; set; }
        public double? MinGlideDistanceTolerance { get; set; }
        public double? LookForwardOffset { get; set; }
        public double? LookUpOffset { get; set; }
        public double? MinimumVerticalDampeningDistance { get; set; }
        public double? MaximumVerticalDampeningDistance { get; set; }
        public double? MinimumIgnoreJumpDistance { get; set; }
        public double? MaximumIgnoreJumpDistance { get; set; }
        public double? MaximumAutoGlideAngle { get; set; }
        public double? MinimumTetherGlideDistance { get; set; }
        public double? YawSignCorrection { get; set; }
        public double? Set1LookForwardOffset { get; set; }
        public double? Set1LookUpOffset { get; set; }
        public double? Set2LookForwardOffset { get; set; }
        public double? Set2LookUpOffset { get; set; }
        public double? Set0SpeedInfluenceOnDir { get; set; }
        public double? Set1SpeedInfluenceOnDir { get; set; }
        public double? Set2SpeedInfluenceOnDir { get; set; }
        public double? Set0AngularRelaxation { get; set; }
        public double? Set1AngularRelaxation { get; set; }
        public double? Set2AngularRelaxation { get; set; }
        public double? Set0PositionUpOffset { get; set; }
        public double? Set1PositionUpOffset { get; set; }
        public double? Set2PositionUpOffset { get; set; }
        public double? Set0PositionForwardOffset { get; set; }
        public double? Set1PositionForwardOffset { get; set; }
        public double? Set2PositionForwardOffset { get; set; }
        public double? Set0Fov { get; set; }
        public double? Set1Fov { get; set; }
        public double? Set2Fov { get; set; }
        public double? Set0MaxYawAngle { get; set; }
        public double? Set1MaxYawAngle { get; set; }
        public double? Set2MaxYawAngle { get; set; }
        public long? Set1FadeInCameraSetChange { get; set; }
        public long? Set1FadeOutCameraSetChange { get; set; }
        public long? Set2FadeInCameraSetChange { get; set; }
        public long? Set2FadeOutCameraSetChange { get; set; }
        public double? InputMovementScalar { get; set; }
        public double? InputRotationScalar { get; set; }
        public double? InputZoomScalar { get; set; }
        public double? MinimumPitchDesired { get; set; }
        public double? MaximumPitchDesired { get; set; }
        public double? MinimumZoom { get; set; }
        public double? MaximumZoom { get; set; }
        public double? HorizontalRotateTolerance { get; set; }
        public double? HorizontalRotateModifier { get; set; }
    }
}
