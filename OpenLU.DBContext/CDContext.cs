using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OpenLU.DBContext.Client
{
    public partial class CDContext : DbContext
    {
        public CDContext()
        {


        }

        public CDContext(DbContextOptions<CDContext> options)
            : base(options)
        {
        }

       

        public virtual DbSet<AccessoryDefaultLoc> AccessoryDefaultLoc { get; set; }
        public virtual DbSet<Activities> Activities { get; set; }
        public virtual DbSet<ActivityRewards> ActivityRewards { get; set; }
        public virtual DbSet<ActivityText> ActivityText { get; set; }
        public virtual DbSet<AicombatRoles> AicombatRoles { get; set; }
        public virtual DbSet<AnimationIndex> AnimationIndex { get; set; }
        public virtual DbSet<Animations> Animations { get; set; }
        public virtual DbSet<BaseCombatAicomponent> BaseCombatAicomponent { get; set; }
        public virtual DbSet<BehaviorEffect> BehaviorEffect { get; set; }
        public virtual DbSet<BehaviorParameter> BehaviorParameter { get; set; }
        public virtual DbSet<BehaviorTemplate> BehaviorTemplate { get; set; }
        public virtual DbSet<BehaviorTemplateName> BehaviorTemplateName { get; set; }
        public virtual DbSet<Blueprints> Blueprints { get; set; }
        public virtual DbSet<BrickAttributes> BrickAttributes { get; set; }
        public virtual DbSet<BrickColors> BrickColors { get; set; }
        public virtual DbSet<BrickIdtable> BrickIdtable { get; set; }
        public virtual DbSet<BuffDefinitions> BuffDefinitions { get; set; }
        public virtual DbSet<BuffParameters> BuffParameters { get; set; }
        public virtual DbSet<Camera> Camera { get; set; }
        public virtual DbSet<CelebrationParameters> CelebrationParameters { get; set; }
        public virtual DbSet<ChoiceBuildComponent> ChoiceBuildComponent { get; set; }
        public virtual DbSet<CollectibleComponent> CollectibleComponent { get; set; }
        public virtual DbSet<ComponentsRegistry> ComponentsRegistry { get; set; }
        public virtual DbSet<ControlSchemes> ControlSchemes { get; set; }
        public virtual DbSet<CurrencyDenominations> CurrencyDenominations { get; set; }
        public virtual DbSet<CurrencyTable> CurrencyTable { get; set; }
        public virtual DbSet<Dbexclude> Dbexclude { get; set; }
        public virtual DbSet<DeletionRestrictions> DeletionRestrictions { get; set; }
        public virtual DbSet<DestructibleComponent> DestructibleComponent { get; set; }
        public virtual DbSet<DevModelBehaviors> DevModelBehaviors { get; set; }
        public virtual DbSet<Dtproperties> Dtproperties { get; set; }
        public virtual DbSet<Emotes> Emotes { get; set; }
        public virtual DbSet<EventGating> EventGating { get; set; }
        public virtual DbSet<ExhibitComponent> ExhibitComponent { get; set; }
        public virtual DbSet<Factions> Factions { get; set; }
        public virtual DbSet<FeatureGating> FeatureGating { get; set; }
        public virtual DbSet<FlairTable> FlairTable { get; set; }
        public virtual DbSet<Icons> Icons { get; set; }
        public virtual DbSet<InventoryComponent> InventoryComponent { get; set; }
        public virtual DbSet<ItemComponent> ItemComponent { get; set; }
        public virtual DbSet<ItemEggData> ItemEggData { get; set; }
        public virtual DbSet<ItemFoodData> ItemFoodData { get; set; }
        public virtual DbSet<ItemSetSkills> ItemSetSkills { get; set; }
        public virtual DbSet<ItemSets> ItemSets { get; set; }
        public virtual DbSet<JetPackPadComponent> JetPackPadComponent { get; set; }
        public virtual DbSet<LanguageType> LanguageType { get; set; }
        public virtual DbSet<LevelProgressionLookup> LevelProgressionLookup { get; set; }
        public virtual DbSet<LootMatrix> LootMatrix { get; set; }
        public virtual DbSet<LootMatrixIndex> LootMatrixIndex { get; set; }
        public virtual DbSet<LootTable> LootTable { get; set; }
        public virtual DbSet<LootTableIndex> LootTableIndex { get; set; }
        public virtual DbSet<LupexhibitComponent> LupexhibitComponent { get; set; }
        public virtual DbSet<LupexhibitModelData> LupexhibitModelData { get; set; }
        public virtual DbSet<LupzoneIds> LupzoneIds { get; set; }
        public virtual DbSet<MapAnimationPriorities> MapAnimationPriorities { get; set; }
        public virtual DbSet<MapAssetType> MapAssetType { get; set; }
        public virtual DbSet<MapBlueprintCategory> MapBlueprintCategory { get; set; }
        public virtual DbSet<MapIcon> MapIcon { get; set; }
        public virtual DbSet<MapItemTypes> MapItemTypes { get; set; }
        public virtual DbSet<MapRenderEffects> MapRenderEffects { get; set; }
        public virtual DbSet<MapShaders> MapShaders { get; set; }
        public virtual DbSet<MapTextureResource> MapTextureResource { get; set; }
        public virtual DbSet<MinifigComponent> MinifigComponent { get; set; }
        public virtual DbSet<MinifigDecalsEyebrows> MinifigDecalsEyebrows { get; set; }
        public virtual DbSet<MinifigDecalsEyes> MinifigDecalsEyes { get; set; }
        public virtual DbSet<MinifigDecalsLegs> MinifigDecalsLegs { get; set; }
        public virtual DbSet<MinifigDecalsMouths> MinifigDecalsMouths { get; set; }
        public virtual DbSet<MinifigDecalsTorsos> MinifigDecalsTorsos { get; set; }
        public virtual DbSet<MissionEmail> MissionEmail { get; set; }
        public virtual DbSet<MissionNpccomponent> MissionNpccomponent { get; set; }
        public virtual DbSet<MissionTasks> MissionTasks { get; set; }
        public virtual DbSet<MissionText> MissionText { get; set; }
        public virtual DbSet<Missions> Missions { get; set; }
        public virtual DbSet<ModelBehavior> ModelBehavior { get; set; }
        public virtual DbSet<ModularBuildComponent> ModularBuildComponent { get; set; }
        public virtual DbSet<ModuleComponent> ModuleComponent { get; set; }
        public virtual DbSet<MotionFx> MotionFx { get; set; }
        public virtual DbSet<MovementAicomponent> MovementAicomponent { get; set; }
        public virtual DbSet<MovingPlatforms> MovingPlatforms { get; set; }
        public virtual DbSet<NpcIcons> NpcIcons { get; set; }
        public virtual DbSet<ObjectBehaviorXref> ObjectBehaviorXref { get; set; }
        public virtual DbSet<ObjectBehaviors> ObjectBehaviors { get; set; }
        public virtual DbSet<ObjectSkills> ObjectSkills { get; set; }
        public virtual DbSet<Objects> Objects { get; set; }
        public virtual DbSet<PackageComponent> PackageComponent { get; set; }
        public virtual DbSet<PetAbilities> PetAbilities { get; set; }
        public virtual DbSet<PetComponent> PetComponent { get; set; }
        public virtual DbSet<PetNestComponent> PetNestComponent { get; set; }
        public virtual DbSet<PhysicsComponent> PhysicsComponent { get; set; }
        public virtual DbSet<PlayerFlags> PlayerFlags { get; set; }
        public virtual DbSet<PlayerStatistics> PlayerStatistics { get; set; }
        public virtual DbSet<PossessableComponent> PossessableComponent { get; set; }
        public virtual DbSet<Preconditions> Preconditions { get; set; }
        public virtual DbSet<PropertyEntranceComponent> PropertyEntranceComponent { get; set; }
        public virtual DbSet<PropertyTemplate> PropertyTemplate { get; set; }
        public virtual DbSet<ProximityMonitorComponent> ProximityMonitorComponent { get; set; }
        public virtual DbSet<ProximityTypes> ProximityTypes { get; set; }
        public virtual DbSet<RacingModuleComponent> RacingModuleComponent { get; set; }
        public virtual DbSet<RailActivatorComponent> RailActivatorComponent { get; set; }
        public virtual DbSet<RarityTable> RarityTable { get; set; }
        public virtual DbSet<RarityTableIndex> RarityTableIndex { get; set; }
        public virtual DbSet<RebuildComponent> RebuildComponent { get; set; }
        public virtual DbSet<RebuildSections> RebuildSections { get; set; }
        public virtual DbSet<ReleaseVersion> ReleaseVersion { get; set; }
        public virtual DbSet<RenderComponent> RenderComponent { get; set; }
        public virtual DbSet<RenderComponentFlash> RenderComponentFlash { get; set; }
        public virtual DbSet<RenderComponentWrapper> RenderComponentWrapper { get; set; }
        public virtual DbSet<RenderIconAssets> RenderIconAssets { get; set; }
        public virtual DbSet<ReputationRewards> ReputationRewards { get; set; }
        public virtual DbSet<RewardCodes> RewardCodes { get; set; }
        public virtual DbSet<Rewards> Rewards { get; set; }
        public virtual DbSet<RocketLaunchpadControlComponent> RocketLaunchpadControlComponent { get; set; }
        public virtual DbSet<SceneTable> SceneTable { get; set; }
        public virtual DbSet<ScriptComponent> ScriptComponent { get; set; }
        public virtual DbSet<SkillBehavior> SkillBehavior { get; set; }
        public virtual DbSet<SmashableChain> SmashableChain { get; set; }
        public virtual DbSet<SmashableChainIndex> SmashableChainIndex { get; set; }
        public virtual DbSet<SmashableComponent> SmashableComponent { get; set; }
        public virtual DbSet<SmashableElements> SmashableElements { get; set; }
        public virtual DbSet<SpeedchatMenu> SpeedchatMenu { get; set; }
        public virtual DbSet<SubscriptionPricing> SubscriptionPricing { get; set; }
        public virtual DbSet<SurfaceType> SurfaceType { get; set; }
        public virtual DbSet<Sysdiagrams> Sysdiagrams { get; set; }
        public virtual DbSet<TamingBuildPuzzles> TamingBuildPuzzles { get; set; }
        public virtual DbSet<TextDescription> TextDescription { get; set; }
        public virtual DbSet<TextLanguage> TextLanguage { get; set; }
        public virtual DbSet<TrailEffects> TrailEffects { get; set; }
        public virtual DbSet<UgbehaviorSounds> UgbehaviorSounds { get; set; }
        public virtual DbSet<VehiclePhysics> VehiclePhysics { get; set; }
        public virtual DbSet<VehicleStatMap> VehicleStatMap { get; set; }
        public virtual DbSet<VendorComponent> VendorComponent { get; set; }
        public virtual DbSet<WhatsCoolItemSpotlight> WhatsCoolItemSpotlight { get; set; }
        public virtual DbSet<WhatsCoolNewsAndTips> WhatsCoolNewsAndTips { get; set; }
        public virtual DbSet<WorldConfig> WorldConfig { get; set; }
        public virtual DbSet<ZoneLoadingTips> ZoneLoadingTips { get; set; }
        public virtual DbSet<ZoneSummary> ZoneSummary { get; set; }
        public virtual DbSet<ZoneTable> ZoneTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlite("Data Source = ./cdclient.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessoryDefaultLoc>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description).HasColumnType("text_4");

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .HasColumnType("int32");

                entity.Property(e => e.PosX).HasColumnName("Pos_X");

                entity.Property(e => e.PosY).HasColumnName("Pos_Y");

                entity.Property(e => e.PosZ).HasColumnName("Pos_Z");

                entity.Property(e => e.RotX).HasColumnName("Rot_X");

                entity.Property(e => e.RotY).HasColumnName("Rot_Y");

                entity.Property(e => e.RotZ).HasColumnName("Rot_Z");
            });

            modelBuilder.Entity<Activities>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ActivityId)
                    .HasColumnName("ActivityID")
                    .HasColumnType("int32");

                entity.Property(e => e.CommunityActivityFlagId)
                    .HasColumnName("CommunityActivityFlagID")
                    .HasColumnType("int32");

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.InstanceMapId)
                    .HasColumnName("instanceMapID")
                    .HasColumnType("int32");

                entity.Property(e => e.LeaderboardType)
                    .HasColumnName("leaderboardType")
                    .HasColumnType("int32");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.Localize)
                    .HasColumnName("localize")
                    .HasColumnType("int_bool");

                entity.Property(e => e.MaxTeamSize)
                    .HasColumnName("maxTeamSize")
                    .HasColumnType("int32");

                entity.Property(e => e.MaxTeams)
                    .HasColumnName("maxTeams")
                    .HasColumnType("int32");

                entity.Property(e => e.MinTeamSize)
                    .HasColumnName("minTeamSize")
                    .HasColumnType("int32");

                entity.Property(e => e.MinTeams)
                    .HasColumnName("minTeams")
                    .HasColumnType("int32");

                entity.Property(e => e.NoTeamLootOnDeath)
                    .HasColumnName("noTeamLootOnDeath")
                    .HasColumnType("int_bool");

                entity.Property(e => e.OptionalCostCount)
                    .HasColumnName("optionalCostCount")
                    .HasColumnType("int32");

                entity.Property(e => e.OptionalCostLot)
                    .HasColumnName("optionalCostLOT")
                    .HasColumnType("int32");

                entity.Property(e => e.OptionalPercentage).HasColumnName("optionalPercentage");

                entity.Property(e => e.RequiresUniqueData)
                    .HasColumnName("requiresUniqueData")
                    .HasColumnType("int_bool");

                entity.Property(e => e.ShowUirewards)
                    .HasColumnName("showUIRewards")
                    .HasColumnType("int_bool");

                entity.Property(e => e.StartDelay)
                    .HasColumnName("startDelay")
                    .HasColumnType("int32");

                entity.Property(e => e.WaitTime)
                    .HasColumnName("waitTime")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<ActivityRewards>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ActivityRating)
                    .HasColumnName("activityRating")
                    .HasColumnType("int32");

                entity.Property(e => e.ActivityRewardIndex).HasColumnType("int32");

                entity.Property(e => e.ChallengeRating).HasColumnType("int32");

                entity.Property(e => e.CurrencyIndex).HasColumnType("int32");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text_4");

                entity.Property(e => e.LootMatrixIndex).HasColumnType("int32");

                entity.Property(e => e.ObjectTemplate)
                    .HasColumnName("objectTemplate")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<ActivityText>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ActivityId)
                    .HasColumnName("activityID")
                    .HasColumnType("int32");

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.Localize)
                    .HasColumnName("localize")
                    .HasColumnType("int_bool");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("text_4");
            });

            modelBuilder.Entity<AicombatRoles>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AICombatRoles");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.PreferredRole)
                    .HasColumnName("preferredRole")
                    .HasColumnType("int32");

                entity.Property(e => e.SpecificMaxRange).HasColumnName("specificMaxRange");

                entity.Property(e => e.SpecificMinRange).HasColumnName("specificMinRange");

                entity.Property(e => e.SpecifiedMaxRangeNouse).HasColumnName("specifiedMaxRangeNOUSE");

                entity.Property(e => e.SpecifiedMinRangeNouse).HasColumnName("specifiedMinRangeNOUSE");
            });

            modelBuilder.Entity<AnimationIndex>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AnimationGroupId)
                    .HasColumnName("animationGroupID")
                    .HasColumnType("int32");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text_4");

                entity.Property(e => e.GroupType)
                    .HasColumnName("groupType")
                    .HasColumnType("text_4");
            });

            modelBuilder.Entity<Animations>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AnimationGroupId)
                    .HasColumnName("animationGroupID")
                    .HasColumnType("int32");

                entity.Property(e => e.AnimationLength).HasColumnName("animation_length");

                entity.Property(e => e.AnimationName)
                    .HasColumnName("animation_name")
                    .HasColumnType("text_4");

                entity.Property(e => e.AnimationType)
                    .HasColumnName("animation_type")
                    .HasColumnType("text_4");

                entity.Property(e => e.BlendTime).HasColumnName("blendTime");

                entity.Property(e => e.ChanceToPlay).HasColumnName("chance_to_play");

                entity.Property(e => e.FaceAnimationName)
                    .HasColumnName("face_animation_name")
                    .HasColumnType("text_4");

                entity.Property(e => e.HideEquip)
                    .HasColumnName("hideEquip")
                    .HasColumnType("int_bool");

                entity.Property(e => e.IgnoreUpperBody)
                    .HasColumnName("ignoreUpperBody")
                    .HasColumnType("int_bool");

                entity.Property(e => e.MaxLoops)
                    .HasColumnName("max_loops")
                    .HasColumnType("int32");

                entity.Property(e => e.MinLoops)
                    .HasColumnName("min_loops")
                    .HasColumnType("int32");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Restartable)
                    .HasColumnName("restartable")
                    .HasColumnType("int_bool");
            });

            modelBuilder.Entity<BaseCombatAicomponent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BaseCombatAIComponent");

                entity.Property(e => e.AggroRadius).HasColumnName("aggroRadius");

                entity.Property(e => e.BehaviorType)
                    .HasColumnName("behaviorType")
                    .HasColumnType("int32");

                entity.Property(e => e.CombatRole)
                    .HasColumnName("combatRole")
                    .HasColumnType("int32");

                entity.Property(e => e.CombatRoundLength).HasColumnName("combatRoundLength");

                entity.Property(e => e.CombatStartDelay).HasColumnName("combatStartDelay");

                entity.Property(e => e.HardTetherRadius).HasColumnName("hardTetherRadius");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.IgnoreMediator)
                    .HasColumnName("ignoreMediator")
                    .HasColumnType("int_bool");

                entity.Property(e => e.IgnoreParent)
                    .HasColumnName("ignoreParent")
                    .HasColumnType("int_bool");

                entity.Property(e => e.IgnoreStatReset)
                    .HasColumnName("ignoreStatReset")
                    .HasColumnType("int_bool");

                entity.Property(e => e.MaxRoundLength).HasColumnName("maxRoundLength");

                entity.Property(e => e.MinRoundLength).HasColumnName("minRoundLength");

                entity.Property(e => e.PursuitSpeed).HasColumnName("pursuitSpeed");

                entity.Property(e => e.SoftTetherRadius).HasColumnName("softTetherRadius");

                entity.Property(e => e.SpawnTimer).HasColumnName("spawnTimer");

                entity.Property(e => e.TetherEffectId)
                    .HasColumnName("tetherEffectID")
                    .HasColumnType("int32");

                entity.Property(e => e.TetherSpeed).HasColumnName("tetherSpeed");
            });

            modelBuilder.Entity<BehaviorEffect>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AnimationName)
                    .HasColumnName("animationName")
                    .HasColumnType("text_4");

                entity.Property(e => e.AttachToObject)
                    .HasColumnName("attachToObject")
                    .HasColumnType("int_bool");

                entity.Property(e => e.AudioEventGuid)
                    .HasColumnName("AudioEventGUID")
                    .HasColumnType("text_4");

                entity.Property(e => e.BoneName)
                    .HasColumnName("boneName")
                    .HasColumnType("text_4");

                entity.Property(e => e.CameraDuration).HasColumnName("cameraDuration");

                entity.Property(e => e.CameraEffectType)
                    .HasColumnName("cameraEffectType")
                    .HasColumnType("int32");

                entity.Property(e => e.CameraFrequency).HasColumnName("cameraFrequency");

                entity.Property(e => e.CameraPitch).HasColumnName("cameraPitch");

                entity.Property(e => e.CameraRoll).HasColumnName("cameraRoll");

                entity.Property(e => e.CameraRotFrequency).HasColumnName("cameraRotFrequency");

                entity.Property(e => e.CameraXamp).HasColumnName("cameraXAmp");

                entity.Property(e => e.CameraYamp).HasColumnName("cameraYAmp");

                entity.Property(e => e.CameraYaw).HasColumnName("cameraYaw");

                entity.Property(e => e.CameraZamp).HasColumnName("cameraZAmp");

                entity.Property(e => e.EffectId)
                    .HasColumnName("effectID")
                    .HasColumnType("int32");

                entity.Property(e => e.EffectName)
                    .HasColumnName("effectName")
                    .HasColumnType("text_4");

                entity.Property(e => e.EffectType)
                    .HasColumnName("effectType")
                    .HasColumnType("text_4");

                entity.Property(e => e.MeshDuration).HasColumnName("meshDuration");

                entity.Property(e => e.MeshId)
                    .HasColumnName("meshID")
                    .HasColumnType("int32");

                entity.Property(e => e.MeshLockedNode)
                    .HasColumnName("meshLockedNode")
                    .HasColumnType("text_4");

                entity.Property(e => e.MotionId)
                    .HasColumnName("motionID")
                    .HasColumnType("int32");

                entity.Property(e => e.PcreateDuration).HasColumnName("pcreateDuration");

                entity.Property(e => e.RenderDelayVal).HasColumnName("renderDelayVal");

                entity.Property(e => e.RenderEffectTime).HasColumnName("renderEffectTime");

                entity.Property(e => e.RenderEffectType)
                    .HasColumnName("renderEffectType")
                    .HasColumnType("int32");

                entity.Property(e => e.RenderEndVal).HasColumnName("renderEndVal");

                entity.Property(e => e.RenderRgba)
                    .HasColumnName("renderRGBA")
                    .HasColumnType("text_4");

                entity.Property(e => e.RenderShaderVal)
                    .HasColumnName("renderShaderVal")
                    .HasColumnType("int32");

                entity.Property(e => e.RenderStartVal).HasColumnName("renderStartVal");

                entity.Property(e => e.RenderValue1).HasColumnName("renderValue1");

                entity.Property(e => e.RenderValue2).HasColumnName("renderValue2");

                entity.Property(e => e.RenderValue3).HasColumnName("renderValue3");

                entity.Property(e => e.TrailId)
                    .HasColumnName("trailID")
                    .HasColumnType("int32");

                entity.Property(e => e.UseSecondary)
                    .HasColumnName("useSecondary")
                    .HasColumnType("int_bool");
            });

            modelBuilder.Entity<BehaviorParameter>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BehaviorId)
                    .HasColumnName("behaviorID")
                    .HasColumnType("int32");

                entity.Property(e => e.ParameterId)
                    .HasColumnName("parameterID")
                    .HasColumnType("text_4");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<BehaviorTemplate>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BehaviorId)
                    .HasColumnName("behaviorID")
                    .HasColumnType("int32");

                entity.Property(e => e.EffectHandle)
                    .HasColumnName("effectHandle")
                    .HasColumnType("text_4");

                entity.Property(e => e.EffectId)
                    .HasColumnName("effectID")
                    .HasColumnType("int32");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("templateID")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<BehaviorTemplateName>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("text_4");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("templateID")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<Blueprints>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Accountid)
                    .HasColumnName("accountid")
                    .HasColumnType("int64");

                entity.Property(e => e.Categoryid)
                    .HasColumnName("categoryid")
                    .HasColumnType("int32");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int64");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("int64");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("int_bool");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int64");

                entity.Property(e => e.Lxfpath)
                    .HasColumnName("lxfpath")
                    .HasColumnType("text_4");

                entity.Property(e => e.Modified)
                    .HasColumnName("modified")
                    .HasColumnType("int64");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("text_4");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("int32");

                entity.Property(e => e.Rating)
                    .HasColumnName("rating")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<BrickAttributes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brickAttributes");

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("display_order")
                    .HasColumnType("int32");

                entity.Property(e => e.IconAsset)
                    .HasColumnName("icon_asset")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int32");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<BrickColors>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Alpha).HasColumnName("alpha");

                entity.Property(e => e.Blue).HasColumnName("blue");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text_4");

                entity.Property(e => e.FactoryValid)
                    .HasColumnName("factoryValid")
                    .HasColumnType("int_bool");

                entity.Property(e => e.Green).HasColumnName("green");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.Legopaletteid)
                    .HasColumnName("legopaletteid")
                    .HasColumnType("int32");

                entity.Property(e => e.Red).HasColumnName("red");

                entity.Property(e => e.ValidCharacters)
                    .HasColumnName("validCharacters")
                    .HasColumnType("int32");

                entity.Property(e => e.ValidTypes)
                    .HasColumnName("validTypes")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<BrickIdtable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BrickIDTable");

                entity.Property(e => e.LegobrickId)
                    .HasColumnName("LEGOBrickID")
                    .HasColumnType("int32");

                entity.Property(e => e.NdobjectId)
                    .HasColumnName("NDObjectID")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<BuffDefinitions>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int32");

                entity.Property(e => e.Uiicon)
                    .HasColumnName("UIIcon")
                    .HasColumnType("text_4");
            });

            modelBuilder.Entity<BuffParameters>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BuffId)
                    .HasColumnName("BuffID")
                    .HasColumnType("int32");

                entity.Property(e => e.EffectId)
                    .HasColumnName("EffectID")
                    .HasColumnType("int32");

                entity.Property(e => e.ParameterName).HasColumnType("text_4");

                entity.Property(e => e.StringValue).HasColumnType("text_4");
            });

            modelBuilder.Entity<Camera>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CameraCollisionPadding).HasColumnName("camera_collision_padding");

                entity.Property(e => e.CameraName)
                    .HasColumnName("camera_name")
                    .HasColumnType("text_4");

                entity.Property(e => e.FadePlayerMinRange).HasColumnName("fade_player_min_range");

                entity.Property(e => e.GlideSpeed).HasColumnName("glide_speed");

                entity.Property(e => e.HorizontalReturnModifier).HasColumnName("horizontal_return_modifier");

                entity.Property(e => e.HorizontalRotateModifier).HasColumnName("horizontal_rotate_modifier");

                entity.Property(e => e.HorizontalRotateTolerance).HasColumnName("horizontal_rotate_tolerance");

                entity.Property(e => e.InputMovementScalar).HasColumnName("input_movement_scalar");

                entity.Property(e => e.InputRotationScalar).HasColumnName("input_rotation_scalar");

                entity.Property(e => e.InputZoomScalar).HasColumnName("input_zoom_scalar");

                entity.Property(e => e.LookForwardOffset).HasColumnName("look_forward_offset");

                entity.Property(e => e.LookUpOffset).HasColumnName("look_up_offset");

                entity.Property(e => e.MaximumAutoGlideAngle).HasColumnName("maximum_auto_glide_angle");

                entity.Property(e => e.MaximumIgnoreJumpDistance).HasColumnName("maximum_ignore_jump_distance");

                entity.Property(e => e.MaximumPitchDesired).HasColumnName("maximum_pitch_desired");

                entity.Property(e => e.MaximumVerticalDampeningDistance).HasColumnName("maximum_vertical_dampening_distance");

                entity.Property(e => e.MaximumZoom).HasColumnName("maximum_zoom");

                entity.Property(e => e.MinGlideDistanceTolerance).HasColumnName("min_glide_distance_tolerance");

                entity.Property(e => e.MinMovementDeltaTolerance).HasColumnName("min_movement_delta_tolerance");

                entity.Property(e => e.MinimumIgnoreJumpDistance).HasColumnName("minimum_ignore_jump_distance");

                entity.Property(e => e.MinimumPitchDesired).HasColumnName("minimum_pitch_desired");

                entity.Property(e => e.MinimumTetherGlideDistance).HasColumnName("minimum_tether_glide_distance");

                entity.Property(e => e.MinimumVerticalDampeningDistance).HasColumnName("minimum_vertical_dampening_distance");

                entity.Property(e => e.MinimumZoom).HasColumnName("minimum_zoom");

                entity.Property(e => e.PitchAngleTolerance).HasColumnName("pitch_angle_tolerance");

                entity.Property(e => e.PitchReturnModifier).HasColumnName("pitch_return_modifier");

                entity.Property(e => e.ReturnFromInclineModifier).HasColumnName("return_from_incline_modifier");

                entity.Property(e => e.Set0AngularRelaxation).HasColumnName("set_0_angular_relaxation");

                entity.Property(e => e.Set0Fov).HasColumnName("set_0_FOV");

                entity.Property(e => e.Set0MaxYawAngle).HasColumnName("set_0_max_yaw_angle");

                entity.Property(e => e.Set0PositionForwardOffset).HasColumnName("set_0_position_forward_offset");

                entity.Property(e => e.Set0PositionUpOffset).HasColumnName("set_0_position_up_offset");

                entity.Property(e => e.Set0SpeedInfluenceOnDir).HasColumnName("set_0_speed_influence_on_dir");

                entity.Property(e => e.Set1AngularRelaxation).HasColumnName("set_1_angular_relaxation");

                entity.Property(e => e.Set1FadeInCameraSetChange)
                    .HasColumnName("set_1_fade_in_camera_set_change")
                    .HasColumnType("int32");

                entity.Property(e => e.Set1FadeOutCameraSetChange)
                    .HasColumnName("set_1_fade_out_camera_set_change")
                    .HasColumnType("int32");

                entity.Property(e => e.Set1Fov).HasColumnName("set_1_FOV");

                entity.Property(e => e.Set1LookForwardOffset).HasColumnName("set_1_look_forward_offset");

                entity.Property(e => e.Set1LookUpOffset).HasColumnName("set_1_look_up_offset");

                entity.Property(e => e.Set1MaxYawAngle).HasColumnName("set_1_max_yaw_angle");

                entity.Property(e => e.Set1PositionForwardOffset).HasColumnName("set_1_position_forward_offset");

                entity.Property(e => e.Set1PositionUpOffset).HasColumnName("set_1_position_up_offset");

                entity.Property(e => e.Set1SpeedInfluenceOnDir).HasColumnName("set_1_speed_influence_on_dir");

                entity.Property(e => e.Set2AngularRelaxation).HasColumnName("set_2_angular_relaxation");

                entity.Property(e => e.Set2FadeInCameraSetChange)
                    .HasColumnName("set_2_fade_in_camera_set_change")
                    .HasColumnType("int32");

                entity.Property(e => e.Set2FadeOutCameraSetChange)
                    .HasColumnName("set_2_fade_out_camera_set_change")
                    .HasColumnType("int32");

                entity.Property(e => e.Set2Fov).HasColumnName("set_2_FOV");

                entity.Property(e => e.Set2LookForwardOffset).HasColumnName("set_2_look_forward_offset");

                entity.Property(e => e.Set2LookUpOffset).HasColumnName("set_2_look_up_offset");

                entity.Property(e => e.Set2MaxYawAngle).HasColumnName("set_2_max_yaw_angle");

                entity.Property(e => e.Set2PositionForwardOffset).HasColumnName("set_2_position_forward_offset");

                entity.Property(e => e.Set2PositionUpOffset).HasColumnName("set_2_position_up_offset");

                entity.Property(e => e.Set2SpeedInfluenceOnDir).HasColumnName("set_2_speed_influence_on_dir");

                entity.Property(e => e.StartingZoom).HasColumnName("starting_zoom");

                entity.Property(e => e.TetherInReturnMultiplier).HasColumnName("tether_in_return_multiplier");

                entity.Property(e => e.TetherOutReturnModifier).HasColumnName("tether_out_return_modifier");

                entity.Property(e => e.VerticleMovementDampeningModifier).HasColumnName("verticle_movement_dampening_modifier");

                entity.Property(e => e.YawBehaviorSpeedMultiplier).HasColumnName("yaw_behavior_speed_multiplier");

                entity.Property(e => e.YawSignCorrection).HasColumnName("yaw_sign_correction");

                entity.Property(e => e.ZoomReturnModifier).HasColumnName("zoom_return_modifier");
            });

            modelBuilder.Entity<CelebrationParameters>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AmbientB).HasColumnName("ambientB");

                entity.Property(e => e.AmbientG).HasColumnName("ambientG");

                entity.Property(e => e.AmbientR).HasColumnName("ambientR");

                entity.Property(e => e.Animation)
                    .HasColumnName("animation")
                    .HasColumnType("text_4");

                entity.Property(e => e.BackgroundObject)
                    .HasColumnName("backgroundObject")
                    .HasColumnType("int32");

                entity.Property(e => e.BlendTime).HasColumnName("blendTime");

                entity.Property(e => e.CameraPathLot)
                    .HasColumnName("cameraPathLOT")
                    .HasColumnType("int32");

                entity.Property(e => e.CeleLeadIn).HasColumnName("celeLeadIn");

                entity.Property(e => e.CeleLeadOut).HasColumnName("celeLeadOut");

                entity.Property(e => e.DirectionalB).HasColumnName("directionalB");

                entity.Property(e => e.DirectionalG).HasColumnName("directionalG");

                entity.Property(e => e.DirectionalR).HasColumnName("directionalR");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.FogColorB).HasColumnName("fogColorB");

                entity.Property(e => e.FogColorG).HasColumnName("fogColorG");

                entity.Property(e => e.FogColorR).HasColumnName("fogColorR");

                entity.Property(e => e.IconId)
                    .HasColumnName("iconID")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.LightPositionX).HasColumnName("lightPositionX");

                entity.Property(e => e.LightPositionY).HasColumnName("lightPositionY");

                entity.Property(e => e.LightPositionZ).HasColumnName("lightPositionZ");

                entity.Property(e => e.MainText)
                    .HasColumnName("mainText")
                    .HasColumnType("text_4");

                entity.Property(e => e.MixerProgram)
                    .HasColumnName("mixerProgram")
                    .HasColumnType("text_4");

                entity.Property(e => e.MusicCue)
                    .HasColumnName("musicCue")
                    .HasColumnType("text_4");

                entity.Property(e => e.PathNodeName)
                    .HasColumnName("pathNodeName")
                    .HasColumnType("text_4");

                entity.Property(e => e.SoundGuid)
                    .HasColumnName("soundGUID")
                    .HasColumnType("text_4");

                entity.Property(e => e.SpecularB).HasColumnName("specularB");

                entity.Property(e => e.SpecularG).HasColumnName("specularG");

                entity.Property(e => e.SpecularR).HasColumnName("specularR");

                entity.Property(e => e.SubText)
                    .HasColumnName("subText")
                    .HasColumnType("text_4");
            });

            modelBuilder.Entity<ChoiceBuildComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.ImaginationOverride)
                    .HasColumnName("imaginationOverride")
                    .HasColumnType("int32");

                entity.Property(e => e.Selections)
                    .HasColumnName("selections")
                    .HasColumnType("text_4");
            });

            modelBuilder.Entity<CollectibleComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.RequirementMission)
                    .HasColumnName("requirement_mission")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<ComponentsRegistry>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ComponentId)
                    .HasColumnName("component_id")
                    .HasColumnType("int32");

                entity.Property(e => e.ComponentType)
                    .HasColumnName("component_type")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<ControlSchemes>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ControlScheme)
                    .HasColumnName("control_scheme")
                    .HasColumnType("int32");

                entity.Property(e => e.FreecamFastSpeedMultiplier).HasColumnName("freecam_fast_speed_multiplier");

                entity.Property(e => e.FreecamMouseModifier).HasColumnName("freecam_mouse_modifier");

                entity.Property(e => e.FreecamSlowSpeedMultiplier).HasColumnName("freecam_slow_speed_multiplier");

                entity.Property(e => e.FreecamSpeedModifier).HasColumnName("freecam_speed_modifier");

                entity.Property(e => e.GamepadPitchRotSensitivity).HasColumnName("gamepad_pitch_rot_sensitivity");

                entity.Property(e => e.GamepadTriggerSensitivity).HasColumnName("gamepad_trigger_sensitivity");

                entity.Property(e => e.GamepadYawRotSensitivity).HasColumnName("gamepad_yaw_rot_sensitivity");

                entity.Property(e => e.KeyboardPitchSensitivity).HasColumnName("keyboard_pitch_sensitivity");

                entity.Property(e => e.KeyboardYawSensitivity).HasColumnName("keyboard_yaw_sensitivity");

                entity.Property(e => e.KeyboardZoomSensitivity).HasColumnName("keyboard_zoom_sensitivity");

                entity.Property(e => e.MouseZoomWheelSensitivity).HasColumnName("mouse_zoom_wheel_sensitivity");

                entity.Property(e => e.RotationSpeed).HasColumnName("rotation_speed");

                entity.Property(e => e.RunBackwardSpeed).HasColumnName("run_backward_speed");

                entity.Property(e => e.RunStrafeBackwardSpeed).HasColumnName("run_strafe_backward_speed");

                entity.Property(e => e.RunStrafeForwardSpeed).HasColumnName("run_strafe_forward_speed");

                entity.Property(e => e.RunStrafeSpeed).HasColumnName("run_strafe_speed");

                entity.Property(e => e.SchemeName)
                    .HasColumnName("scheme_name")
                    .HasColumnType("text_4");

                entity.Property(e => e.WalkBackwardSpeed).HasColumnName("walk_backward_speed");

                entity.Property(e => e.WalkForwardSpeed).HasColumnName("walk_forward_speed");

                entity.Property(e => e.WalkStrafeBackwardSpeed).HasColumnName("walk_strafe_backward_speed");

                entity.Property(e => e.WalkStrafeForwardSpeed).HasColumnName("walk_strafe_forward_speed");

                entity.Property(e => e.WalkStrafeSpeed).HasColumnName("walk_strafe_speed");

                entity.Property(e => e.XMouseMoveSensitivityModifier).HasColumnName("x_mouse_move_sensitivity_modifier");

                entity.Property(e => e.YMouseMoveSensitivityModifier).HasColumnName("y_mouse_move_sensitivity_modifier");
            });

            modelBuilder.Entity<CurrencyDenominations>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Objectid)
                    .HasColumnName("objectid")
                    .HasColumnType("int32");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<CurrencyTable>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CurrencyIndex)
                    .HasColumnName("currencyIndex")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.Maxvalue)
                    .HasColumnName("maxvalue")
                    .HasColumnType("int32");

                entity.Property(e => e.Minvalue)
                    .HasColumnName("minvalue")
                    .HasColumnType("int32");

                entity.Property(e => e.Npcminlevel)
                    .HasColumnName("npcminlevel")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<Dbexclude>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DBExclude");

                entity.Property(e => e.Column)
                    .HasColumnName("column")
                    .HasColumnType("text_4");

                entity.Property(e => e.Table)
                    .HasColumnName("table")
                    .HasColumnType("text_4");
            });

            modelBuilder.Entity<DeletionRestrictions>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CheckType)
                    .HasColumnName("checkType")
                    .HasColumnType("int32");

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.Ids)
                    .HasColumnName("ids")
                    .HasColumnType("text_4");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.Localize)
                    .HasColumnName("localize")
                    .HasColumnType("int_bool");

                entity.Property(e => e.Restricted)
                    .HasColumnName("restricted")
                    .HasColumnType("int_bool");
            });

            modelBuilder.Entity<DestructibleComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Armor).HasColumnName("armor");

                entity.Property(e => e.AttackPriority)
                    .HasColumnName("attack_priority")
                    .HasColumnType("int32");

                entity.Property(e => e.CurrencyIndex).HasColumnType("int32");

                entity.Property(e => e.DeathBehavior)
                    .HasColumnName("death_behavior")
                    .HasColumnType("int32");

                entity.Property(e => e.DifficultyLevel)
                    .HasColumnName("difficultyLevel")
                    .HasColumnType("int32");

                entity.Property(e => e.Faction)
                    .HasColumnName("faction")
                    .HasColumnType("int32");

                entity.Property(e => e.FactionList)
                    .HasColumnName("factionList")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.Imagination)
                    .HasColumnName("imagination")
                    .HasColumnType("int32");

                entity.Property(e => e.IsSmashable)
                    .HasColumnName("isSmashable")
                    .HasColumnType("int_bool");

                entity.Property(e => e.Isnpc)
                    .HasColumnName("isnpc")
                    .HasColumnType("int_bool");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("int32");

                entity.Property(e => e.Life)
                    .HasColumnName("life")
                    .HasColumnType("int32");

                entity.Property(e => e.LootMatrixIndex).HasColumnType("int32");
            });

            modelBuilder.Entity<DevModelBehaviors>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BehaviorId)
                    .HasColumnName("BehaviorID")
                    .HasColumnType("int32");

                entity.Property(e => e.ModelId)
                    .HasColumnName("ModelID")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<Dtproperties>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dtproperties");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.Lvalue)
                    .HasColumnName("lvalue")
                    .HasColumnType("none");

                entity.Property(e => e.Objectid)
                    .HasColumnName("objectid")
                    .HasColumnType("int32");

                entity.Property(e => e.Property)
                    .HasColumnName("property")
                    .HasColumnType("text_4");

                entity.Property(e => e.Uvalue)
                    .HasColumnName("uvalue")
                    .HasColumnType("text_4");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("text_4");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<Emotes>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AnimationName)
                    .HasColumnName("animationName")
                    .HasColumnType("text_4");

                entity.Property(e => e.Channel)
                    .HasColumnName("channel")
                    .HasColumnType("text_4");

                entity.Property(e => e.Command)
                    .HasColumnName("command")
                    .HasColumnType("text_4");

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.IconFilename)
                    .HasColumnName("iconFilename")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.Localize)
                    .HasColumnName("localize")
                    .HasColumnType("int_bool");

                entity.Property(e => e.Locked)
                    .HasColumnName("locked")
                    .HasColumnType("int_bool");
            });

            modelBuilder.Entity<EventGating>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateEnd)
                    .HasColumnName("date_end")
                    .HasColumnType("int64");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("int64");

                entity.Property(e => e.EventName)
                    .HasColumnName("eventName")
                    .HasColumnType("text_4");
            });

            modelBuilder.Entity<ExhibitComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FImaginationCost).HasColumnName("fImaginationCost");

                entity.Property(e => e.FReputationSizeMultiplier).HasColumnName("fReputationSizeMultiplier");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.OffsetX).HasColumnName("offsetX");

                entity.Property(e => e.OffsetY).HasColumnName("offsetY");

                entity.Property(e => e.OffsetZ).HasColumnName("offsetZ");

                entity.Property(e => e.Width).HasColumnName("width");
            });

            modelBuilder.Entity<Factions>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EnemyList)
                    .HasColumnName("enemyList")
                    .HasColumnType("text_4");

                entity.Property(e => e.Faction)
                    .HasColumnName("faction")
                    .HasColumnType("int32");

                entity.Property(e => e.FactionList)
                    .HasColumnName("factionList")
                    .HasColumnType("text_4");

                entity.Property(e => e.FactionListFriendly)
                    .HasColumnName("factionListFriendly")
                    .HasColumnType("int_bool");

                entity.Property(e => e.FriendList)
                    .HasColumnName("friendList")
                    .HasColumnType("text_4");
            });

            modelBuilder.Entity<FeatureGating>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Current)
                    .HasColumnName("current")
                    .HasColumnType("int32");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text_4");

                entity.Property(e => e.FeatureName)
                    .HasColumnName("featureName")
                    .HasColumnType("text_4");

                entity.Property(e => e.Major)
                    .HasColumnName("major")
                    .HasColumnType("int32");

                entity.Property(e => e.Minor)
                    .HasColumnName("minor")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<FlairTable>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Asset)
                    .HasColumnName("asset")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<Icons>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IconId)
                    .HasColumnName("IconID")
                    .HasColumnType("int32");

                entity.Property(e => e.IconName).HasColumnType("text_4");

                entity.Property(e => e.IconPath).HasColumnType("text_4");
            });

            modelBuilder.Entity<InventoryComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("int32");

                entity.Property(e => e.Equip)
                    .HasColumnName("equip")
                    .HasColumnType("int_bool");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<ItemComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AltCurrencyCost)
                    .HasColumnName("altCurrencyCost")
                    .HasColumnType("int32");

                entity.Property(e => e.AnimationFlag)
                    .HasColumnName("animationFlag")
                    .HasColumnType("int32");

                entity.Property(e => e.AudioEquipMetaEventSet)
                    .HasColumnName("audioEquipMetaEventSet")
                    .HasColumnType("text_4");

                entity.Property(e => e.AudioEventUse)
                    .HasColumnName("audioEventUse")
                    .HasColumnType("text_4");

                entity.Property(e => e.BaseValue)
                    .HasColumnName("baseValue")
                    .HasColumnType("int32");

                entity.Property(e => e.BuildTypes)
                    .HasColumnName("buildTypes")
                    .HasColumnType("int32");

                entity.Property(e => e.Color1)
                    .HasColumnName("color1")
                    .HasColumnType("int32");

                entity.Property(e => e.CommendationCost)
                    .HasColumnName("commendationCost")
                    .HasColumnType("int32");

                entity.Property(e => e.CommendationLot)
                    .HasColumnName("commendationLOT")
                    .HasColumnType("int32");

                entity.Property(e => e.CurrencyCosts)
                    .HasColumnName("currencyCosts")
                    .HasColumnType("text_4");

                entity.Property(e => e.CurrencyLot)
                    .HasColumnName("currencyLOT")
                    .HasColumnType("int32");

                entity.Property(e => e.Decal)
                    .HasColumnName("decal")
                    .HasColumnType("int32");

                entity.Property(e => e.DelResIndex)
                    .HasColumnName("delResIndex")
                    .HasColumnType("int32");

                entity.Property(e => e.EquipEffects)
                    .HasColumnName("equipEffects")
                    .HasColumnType("int32");

                entity.Property(e => e.EquipLocation)
                    .HasColumnName("equipLocation")
                    .HasColumnType("text_4");

                entity.Property(e => e.ForgeType)
                    .HasColumnName("forgeType")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.InLootTable)
                    .HasColumnName("inLootTable")
                    .HasColumnType("int_bool");

                entity.Property(e => e.InVendor)
                    .HasColumnName("inVendor")
                    .HasColumnType("int_bool");

                entity.Property(e => e.IngredientInfo)
                    .HasColumnName("ingredientInfo")
                    .HasColumnType("text_4");

                entity.Property(e => e.IsBoe)
                    .HasColumnName("isBOE")
                    .HasColumnType("int_bool");

                entity.Property(e => e.IsBop)
                    .HasColumnName("isBOP")
                    .HasColumnType("int_bool");

                entity.Property(e => e.IsKitPiece)
                    .HasColumnName("isKitPiece")
                    .HasColumnType("int_bool");

                entity.Property(e => e.IsTwoHanded)
                    .HasColumnName("isTwoHanded")
                    .HasColumnType("int_bool");

                entity.Property(e => e.IsUnique)
                    .HasColumnName("isUnique")
                    .HasColumnType("int_bool");

                entity.Property(e => e.ItemInfo)
                    .HasColumnName("itemInfo")
                    .HasColumnType("int64");

                entity.Property(e => e.ItemRating)
                    .HasColumnName("itemRating")
                    .HasColumnType("int32");

                entity.Property(e => e.ItemType)
                    .HasColumnName("itemType")
                    .HasColumnType("int32");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.MinNumRequired)
                    .HasColumnName("minNumRequired")
                    .HasColumnType("int32");

                entity.Property(e => e.NoEquipAnimation)
                    .HasColumnName("noEquipAnimation")
                    .HasColumnType("int_bool");

                entity.Property(e => e.OffsetGroupId)
                    .HasColumnName("offsetGroupID")
                    .HasColumnType("int32");

                entity.Property(e => e.Rarity)
                    .HasColumnName("rarity")
                    .HasColumnType("int32");

                entity.Property(e => e.ReadyForQa)
                    .HasColumnName("readyForQA")
                    .HasColumnType("int_bool");

                entity.Property(e => e.ReqAchievementId)
                    .HasColumnName("reqAchievementID")
                    .HasColumnType("int32");

                entity.Property(e => e.ReqFlagId)
                    .HasColumnName("reqFlagID")
                    .HasColumnType("int32");

                entity.Property(e => e.ReqPrecondition)
                    .HasColumnName("reqPrecondition")
                    .HasColumnType("text_4");

                entity.Property(e => e.ReqSpecRank)
                    .HasColumnName("reqSpecRank")
                    .HasColumnType("int32");

                entity.Property(e => e.ReqSpecialtyId)
                    .HasColumnName("reqSpecialtyID")
                    .HasColumnType("int32");

                entity.Property(e => e.StackSize)
                    .HasColumnName("stackSize")
                    .HasColumnType("int32");

                entity.Property(e => e.SubItems)
                    .HasColumnName("subItems")
                    .HasColumnType("text_4");
            });

            modelBuilder.Entity<ItemEggData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ChassieTypeId)
                    .HasColumnName("chassie_type_id")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<ItemFoodData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Element1)
                    .HasColumnName("element_1")
                    .HasColumnType("int32");

                entity.Property(e => e.Element1Amount)
                    .HasColumnName("element_1_amount")
                    .HasColumnType("int32");

                entity.Property(e => e.Element2)
                    .HasColumnName("element_2")
                    .HasColumnType("int32");

                entity.Property(e => e.Element2Amount)
                    .HasColumnName("element_2_amount")
                    .HasColumnType("int32");

                entity.Property(e => e.Element3)
                    .HasColumnName("element_3")
                    .HasColumnType("int32");

                entity.Property(e => e.Element3Amount)
                    .HasColumnName("element_3_amount")
                    .HasColumnType("int32");

                entity.Property(e => e.Element4)
                    .HasColumnName("element_4")
                    .HasColumnType("int32");

                entity.Property(e => e.Element4Amount)
                    .HasColumnName("element_4_amount")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<ItemSetSkills>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SkillCastType).HasColumnType("int32");

                entity.Property(e => e.SkillId)
                    .HasColumnName("SkillID")
                    .HasColumnType("int32");

                entity.Property(e => e.SkillSetId)
                    .HasColumnName("SkillSetID")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<ItemSets>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.ItemIds)
                    .HasColumnName("itemIDs")
                    .HasColumnType("text_4");

                entity.Property(e => e.KitId)
                    .HasColumnName("kitID")
                    .HasColumnType("int32");

                entity.Property(e => e.KitImage)
                    .HasColumnName("kitImage")
                    .HasColumnType("int32");

                entity.Property(e => e.KitRank)
                    .HasColumnName("kitRank")
                    .HasColumnType("int32");

                entity.Property(e => e.KitType)
                    .HasColumnName("kitType")
                    .HasColumnType("int32");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.Localize)
                    .HasColumnName("localize")
                    .HasColumnType("int_bool");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.SetId)
                    .HasColumnName("setID")
                    .HasColumnType("int32");

                entity.Property(e => e.SkillSetWith2)
                    .HasColumnName("skillSetWith2")
                    .HasColumnType("int32");

                entity.Property(e => e.SkillSetWith3)
                    .HasColumnName("skillSetWith3")
                    .HasColumnType("int32");

                entity.Property(e => e.SkillSetWith4)
                    .HasColumnName("skillSetWith4")
                    .HasColumnType("int32");

                entity.Property(e => e.SkillSetWith5)
                    .HasColumnName("skillSetWith5")
                    .HasColumnType("int32");

                entity.Property(e => e.SkillSetWith6)
                    .HasColumnName("skillSetWith6")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<JetPackPadComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.LotBlocker)
                    .HasColumnName("lotBlocker")
                    .HasColumnType("int32");

                entity.Property(e => e.LotWarningVolume)
                    .HasColumnName("lotWarningVolume")
                    .HasColumnType("int32");

                entity.Property(e => e.WarnDistance).HasColumnName("warnDistance");

                entity.Property(e => e.XDistance).HasColumnName("xDistance");

                entity.Property(e => e.YDistance).HasColumnName("yDistance");
            });

            modelBuilder.Entity<LanguageType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LanguageDescription).HasColumnType("text_4");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<LevelProgressionLookup>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BehaviorEffect).HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.RequiredUscore)
                    .HasColumnName("requiredUScore")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<LootMatrix>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FlagId)
                    .HasColumnName("flagID")
                    .HasColumnType("int32");

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.LootMatrixIndex).HasColumnType("int32");

                entity.Property(e => e.LootTableIndex).HasColumnType("int32");

                entity.Property(e => e.MaxToDrop)
                    .HasColumnName("maxToDrop")
                    .HasColumnType("int32");

                entity.Property(e => e.MinToDrop)
                    .HasColumnName("minToDrop")
                    .HasColumnType("int32");

                entity.Property(e => e.Percent).HasColumnName("percent");

                entity.Property(e => e.RarityTableIndex).HasColumnType("int32");
            });

            modelBuilder.Entity<LootMatrixIndex>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.InNpcEditor)
                    .HasColumnName("inNpcEditor")
                    .HasColumnType("int_bool");

                entity.Property(e => e.LootMatrixIndex1)
                    .HasColumnName("LootMatrixIndex")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<LootTable>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("int32");

                entity.Property(e => e.LootTableIndex).HasColumnType("int32");

                entity.Property(e => e.MissionDrop).HasColumnType("int_bool");

                entity.Property(e => e.SortPriority)
                    .HasColumnName("sortPriority")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<LootTableIndex>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LootTableIndex1)
                    .HasColumnName("LootTableIndex")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<LupexhibitComponent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LUPExhibitComponent");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.MaxXz).HasColumnName("maxXZ");

                entity.Property(e => e.MaxY).HasColumnName("maxY");

                entity.Property(e => e.MinXz).HasColumnName("minXZ");

                entity.Property(e => e.OffsetX).HasColumnName("offsetX");

                entity.Property(e => e.OffsetY).HasColumnName("offsetY");

                entity.Property(e => e.OffsetZ).HasColumnName("offsetZ");
            });

            modelBuilder.Entity<LupexhibitModelData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LUPExhibitModelData");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text_4");

                entity.Property(e => e.Lot)
                    .HasColumnName("LOT")
                    .HasColumnType("int32");

                entity.Property(e => e.MaxXz).HasColumnName("maxXZ");

                entity.Property(e => e.MaxY).HasColumnName("maxY");

                entity.Property(e => e.MinXz).HasColumnName("minXZ");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasColumnType("text_4");
            });

            modelBuilder.Entity<LupzoneIds>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LUPZoneIDs");

                entity.Property(e => e.ZoneId)
                    .HasColumnName("zoneID")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<MapAnimationPriorities>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mapAnimationPriorities");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("text_4");

                entity.Property(e => e.Priority).HasColumnName("priority");
            });

            modelBuilder.Entity<MapAssetType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mapAssetType");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.Label)
                    .HasColumnName("label")
                    .HasColumnType("text_4");

                entity.Property(e => e.Pathdir)
                    .HasColumnName("pathdir")
                    .HasColumnType("text_4");

                entity.Property(e => e.Typelabel)
                    .HasColumnName("typelabel")
                    .HasColumnType("text_4");
            });

            modelBuilder.Entity<MapBlueprintCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("map_BlueprintCategory");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text_4");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasColumnType("int_bool");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<MapIcon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mapIcon");

                entity.Property(e => e.IconId)
                    .HasColumnName("iconID")
                    .HasColumnType("int32");

                entity.Property(e => e.IconState)
                    .HasColumnName("iconState")
                    .HasColumnType("int32");

                entity.Property(e => e.Lot)
                    .HasColumnName("LOT")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<MapItemTypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mapItemTypes");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text_4");

                entity.Property(e => e.EquipLocation)
                    .HasColumnName("equipLocation")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<MapRenderEffects>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mapRenderEffects");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text_4");

                entity.Property(e => e.GameId)
                    .HasColumnName("gameID")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<MapShaders>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mapShaders");

                entity.Property(e => e.GameValue)
                    .HasColumnName("gameValue")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.Label)
                    .HasColumnName("label")
                    .HasColumnType("text_4");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<MapTextureResource>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mapTextureResource");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.SurfaceType).HasColumnType("int32");

                entity.Property(e => e.Texturepath)
                    .HasColumnName("texturepath")
                    .HasColumnType("text_4");
            });

            modelBuilder.Entity<MinifigComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Chest)
                    .HasColumnName("chest")
                    .HasColumnType("int32");

                entity.Property(e => e.Chestdecal)
                    .HasColumnName("chestdecal")
                    .HasColumnType("int32");

                entity.Property(e => e.Eyebrowstyle)
                    .HasColumnName("eyebrowstyle")
                    .HasColumnType("int32");

                entity.Property(e => e.Eyesstyle)
                    .HasColumnName("eyesstyle")
                    .HasColumnType("int32");

                entity.Property(e => e.Haircolor)
                    .HasColumnName("haircolor")
                    .HasColumnType("int32");

                entity.Property(e => e.Hairstyle)
                    .HasColumnName("hairstyle")
                    .HasColumnType("int32");

                entity.Property(e => e.Head)
                    .HasColumnName("head")
                    .HasColumnType("int32");

                entity.Property(e => e.Headcolor)
                    .HasColumnName("headcolor")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.Lefthand)
                    .HasColumnName("lefthand")
                    .HasColumnType("int32");

                entity.Property(e => e.Legs)
                    .HasColumnName("legs")
                    .HasColumnType("int32");

                entity.Property(e => e.Mouthstyle)
                    .HasColumnName("mouthstyle")
                    .HasColumnType("int32");

                entity.Property(e => e.Righthand)
                    .HasColumnName("righthand")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<MinifigDecalsEyebrows>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MinifigDecals_Eyebrows");

                entity.Property(e => e.CharacterCreateValid).HasColumnType("int_bool");

                entity.Property(e => e.Female)
                    .HasColumnName("female")
                    .HasColumnType("int_bool");

                entity.Property(e => e.HighPath)
                    .HasColumnName("High_path")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int32");

                entity.Property(e => e.LowPath)
                    .HasColumnName("Low_path")
                    .HasColumnType("text_4");

                entity.Property(e => e.Male)
                    .HasColumnName("male")
                    .HasColumnType("int_bool");
            });

            modelBuilder.Entity<MinifigDecalsEyes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MinifigDecals_Eyes");

                entity.Property(e => e.CharacterCreateValid).HasColumnType("int_bool");

                entity.Property(e => e.Female)
                    .HasColumnName("female")
                    .HasColumnType("int_bool");

                entity.Property(e => e.HighPath)
                    .HasColumnName("High_path")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int32");

                entity.Property(e => e.LowPath)
                    .HasColumnName("Low_path")
                    .HasColumnType("text_4");

                entity.Property(e => e.Male)
                    .HasColumnName("male")
                    .HasColumnType("int_bool");
            });

            modelBuilder.Entity<MinifigDecalsLegs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MinifigDecals_Legs");

                entity.Property(e => e.HighPath)
                    .HasColumnName("High_path")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<MinifigDecalsMouths>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MinifigDecals_Mouths");

                entity.Property(e => e.CharacterCreateValid).HasColumnType("int_bool");

                entity.Property(e => e.Female)
                    .HasColumnName("female")
                    .HasColumnType("int_bool");

                entity.Property(e => e.HighPath)
                    .HasColumnName("High_path")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int32");

                entity.Property(e => e.LowPath)
                    .HasColumnName("Low_path")
                    .HasColumnType("text_4");

                entity.Property(e => e.Male)
                    .HasColumnName("male")
                    .HasColumnType("int_bool");
            });

            modelBuilder.Entity<MinifigDecalsTorsos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MinifigDecals_Torsos");

                entity.Property(e => e.CharacterCreateValid).HasColumnType("int_bool");

                entity.Property(e => e.Female)
                    .HasColumnName("female")
                    .HasColumnType("int_bool");

                entity.Property(e => e.HighPath)
                    .HasColumnName("High_path")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int32");

                entity.Property(e => e.Male)
                    .HasColumnName("male")
                    .HasColumnType("int_bool");
            });

            modelBuilder.Entity<MissionEmail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AttachmentLot)
                    .HasColumnName("attachmentLOT")
                    .HasColumnType("int32");

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int32");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.Localize)
                    .HasColumnName("localize")
                    .HasColumnType("int_bool");

                entity.Property(e => e.MessageType)
                    .HasColumnName("messageType")
                    .HasColumnType("int32");

                entity.Property(e => e.MissionId)
                    .HasColumnName("missionID")
                    .HasColumnType("int32");

                entity.Property(e => e.NotificationGroup)
                    .HasColumnName("notificationGroup")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<MissionNpccomponent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MissionNPCComponent");

                entity.Property(e => e.AcceptsMission)
                    .HasColumnName("acceptsMission")
                    .HasColumnType("int_bool");

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.MissionId)
                    .HasColumnName("missionID")
                    .HasColumnType("int32");

                entity.Property(e => e.OffersMission)
                    .HasColumnName("offersMission")
                    .HasColumnType("int_bool");
            });

            modelBuilder.Entity<MissionTasks>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.IconId)
                    .HasColumnName("IconID")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.LargeTaskIcon)
                    .HasColumnName("largeTaskIcon")
                    .HasColumnType("text_4");

                entity.Property(e => e.LargeTaskIconId)
                    .HasColumnName("largeTaskIconID")
                    .HasColumnType("int32");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.Localize)
                    .HasColumnName("localize")
                    .HasColumnType("int_bool");

                entity.Property(e => e.Target)
                    .HasColumnName("target")
                    .HasColumnType("int32");

                entity.Property(e => e.TargetGroup)
                    .HasColumnName("targetGroup")
                    .HasColumnType("text_4");

                entity.Property(e => e.TargetValue)
                    .HasColumnName("targetValue")
                    .HasColumnType("int32");

                entity.Property(e => e.TaskParam1)
                    .HasColumnName("taskParam1")
                    .HasColumnType("text_4");

                entity.Property(e => e.TaskType)
                    .HasColumnName("taskType")
                    .HasColumnType("int32");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<MissionText>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AudioEventGuidCompleted)
                    .HasColumnName("AudioEventGUID_Completed")
                    .HasColumnType("text_4");

                entity.Property(e => e.AudioEventGuidFailed)
                    .HasColumnName("AudioEventGUID_Failed")
                    .HasColumnType("text_4");

                entity.Property(e => e.AudioEventGuidInteract)
                    .HasColumnName("AudioEventGUID_Interact")
                    .HasColumnType("text_4");

                entity.Property(e => e.AudioEventGuidOfferAccept)
                    .HasColumnName("AudioEventGUID_OfferAccept")
                    .HasColumnType("text_4");

                entity.Property(e => e.AudioEventGuidOfferDeny)
                    .HasColumnName("AudioEventGUID_OfferDeny")
                    .HasColumnType("text_4");

                entity.Property(e => e.AudioEventGuidProgress)
                    .HasColumnName("AudioEventGUID_Progress")
                    .HasColumnType("text_4");

                entity.Property(e => e.AudioEventGuidTurnIn)
                    .HasColumnName("AudioEventGUID_TurnIn")
                    .HasColumnType("text_4");

                entity.Property(e => e.AudioMusicCueOfferAccept)
                    .HasColumnName("AudioMusicCue_OfferAccept")
                    .HasColumnType("text_4");

                entity.Property(e => e.AudioMusicCueTurnIn)
                    .HasColumnName("AudioMusicCue_TurnIn")
                    .HasColumnType("text_4");

                entity.Property(e => e.CinematicAccepted).HasColumnType("text_4");

                entity.Property(e => e.CinematicCompleted).HasColumnType("text_4");

                entity.Property(e => e.CinematicRepeatable).HasColumnType("text_4");

                entity.Property(e => e.CinematicRepeatableCompleted).HasColumnType("text_4");

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.IconId)
                    .HasColumnName("IconID")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.Localize)
                    .HasColumnName("localize")
                    .HasColumnType("int_bool");

                entity.Property(e => e.MissionIcon)
                    .HasColumnName("missionIcon")
                    .HasColumnType("text_4");

                entity.Property(e => e.OfferNpcicon)
                    .HasColumnName("offerNPCIcon")
                    .HasColumnType("text_4");

                entity.Property(e => e.OnclickAnim)
                    .HasColumnName("onclick_anim")
                    .HasColumnType("text_4");

                entity.Property(e => e.State1Anim)
                    .HasColumnName("state_1_anim")
                    .HasColumnType("text_4");

                entity.Property(e => e.State2Anim)
                    .HasColumnName("state_2_anim")
                    .HasColumnType("text_4");

                entity.Property(e => e.State3Anim)
                    .HasColumnName("state_3_anim")
                    .HasColumnType("text_4");

                entity.Property(e => e.State3TurninAnim)
                    .HasColumnName("state_3_turnin_anim")
                    .HasColumnType("text_4");

                entity.Property(e => e.State4Anim)
                    .HasColumnName("state_4_anim")
                    .HasColumnType("text_4");

                entity.Property(e => e.State4TurninAnim)
                    .HasColumnName("state_4_turnin_anim")
                    .HasColumnType("text_4");

                entity.Property(e => e.StoryIcon)
                    .HasColumnName("story_icon")
                    .HasColumnType("text_4");

                entity.Property(e => e.TurnInIconId)
                    .HasColumnName("turnInIconID")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<Missions>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CooldownTime)
                    .HasColumnName("cooldownTime")
                    .HasColumnType("int64");

                entity.Property(e => e.DefinedSubtype)
                    .HasColumnName("defined_subtype")
                    .HasColumnType("text_4");

                entity.Property(e => e.DefinedType)
                    .HasColumnName("defined_type")
                    .HasColumnType("text_4");

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.Hudstates)
                    .HasColumnName("HUDStates")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.InMotd)
                    .HasColumnName("inMOTD")
                    .HasColumnType("int_bool");

                entity.Property(e => e.IsChoiceReward)
                    .HasColumnName("isChoiceReward")
                    .HasColumnType("int_bool");

                entity.Property(e => e.IsMission)
                    .HasColumnName("isMission")
                    .HasColumnType("int_bool");

                entity.Property(e => e.IsRandom)
                    .HasColumnName("isRandom")
                    .HasColumnType("int_bool");

                entity.Property(e => e.LegoScore).HasColumnType("int32");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.Localize)
                    .HasColumnName("localize")
                    .HasColumnType("int_bool");

                entity.Property(e => e.MissionIconId)
                    .HasColumnName("missionIconID")
                    .HasColumnType("int32");

                entity.Property(e => e.OfferObjectId)
                    .HasColumnName("offer_objectID")
                    .HasColumnType("int32");

                entity.Property(e => e.PrereqMissionId)
                    .HasColumnName("prereqMissionID")
                    .HasColumnType("text_4");

                entity.Property(e => e.RandomPool)
                    .HasColumnName("randomPool")
                    .HasColumnType("text_4");

                entity.Property(e => e.Repeatable)
                    .HasColumnName("repeatable")
                    .HasColumnType("int_bool");

                entity.Property(e => e.RewardBankinventory)
                    .HasColumnName("reward_bankinventory")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardCurrency)
                    .HasColumnName("reward_currency")
                    .HasColumnType("int64");

                entity.Property(e => e.RewardCurrencyRepeatable)
                    .HasColumnName("reward_currency_repeatable")
                    .HasColumnType("int64");

                entity.Property(e => e.RewardEmote)
                    .HasColumnName("reward_emote")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardEmote2)
                    .HasColumnName("reward_emote2")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardEmote3)
                    .HasColumnName("reward_emote3")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardEmote4)
                    .HasColumnName("reward_emote4")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardItem1)
                    .HasColumnName("reward_item1")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardItem1Count)
                    .HasColumnName("reward_item1_count")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardItem1RepeatCount)
                    .HasColumnName("reward_item1_repeat_count")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardItem1Repeatable)
                    .HasColumnName("reward_item1_repeatable")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardItem2)
                    .HasColumnName("reward_item2")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardItem2Count)
                    .HasColumnName("reward_item2_count")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardItem2RepeatCount)
                    .HasColumnName("reward_item2_repeat_count")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardItem2Repeatable)
                    .HasColumnName("reward_item2_repeatable")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardItem3)
                    .HasColumnName("reward_item3")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardItem3Count)
                    .HasColumnName("reward_item3_count")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardItem3RepeatCount)
                    .HasColumnName("reward_item3_repeat_count")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardItem3Repeatable)
                    .HasColumnName("reward_item3_repeatable")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardItem4)
                    .HasColumnName("reward_item4")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardItem4Count)
                    .HasColumnName("reward_item4_count")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardItem4RepeatCount)
                    .HasColumnName("reward_item4_repeat_count")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardItem4Repeatable)
                    .HasColumnName("reward_item4_repeatable")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardMaxhealth)
                    .HasColumnName("reward_maxhealth")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardMaximagination)
                    .HasColumnName("reward_maximagination")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardMaxinventory)
                    .HasColumnName("reward_maxinventory")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardMaxmodel)
                    .HasColumnName("reward_maxmodel")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardMaxwallet)
                    .HasColumnName("reward_maxwallet")
                    .HasColumnType("int64");

                entity.Property(e => e.RewardMaxwidget)
                    .HasColumnName("reward_maxwidget")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardReputation)
                    .HasColumnName("reward_reputation")
                    .HasColumnType("int64");

                entity.Property(e => e.TargetObjectId)
                    .HasColumnName("target_objectID")
                    .HasColumnType("int32");

                entity.Property(e => e.TimeLimit)
                    .HasColumnName("time_limit")
                    .HasColumnType("int32");

                entity.Property(e => e.UiprereqId)
                    .HasColumnName("UIPrereqID")
                    .HasColumnType("int32");

                entity.Property(e => e.UisortOrder)
                    .HasColumnName("UISortOrder")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<ModelBehavior>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DefinitionXmlfilename)
                    .HasColumnName("definitionXMLfilename")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<ModularBuildComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AudioEventGuidComplete)
                    .HasColumnName("AudioEventGUID_Complete")
                    .HasColumnType("text_4");

                entity.Property(e => e.AudioEventGuidPresent)
                    .HasColumnName("AudioEventGUID_Present")
                    .HasColumnType("text_4");

                entity.Property(e => e.AudioEventGuidSnap)
                    .HasColumnName("AudioEventGUID_Snap")
                    .HasColumnType("text_4");

                entity.Property(e => e.BuildType)
                    .HasColumnName("buildType")
                    .HasColumnType("int32");

                entity.Property(e => e.CreatedLot)
                    .HasColumnName("createdLOT")
                    .HasColumnType("int32");

                entity.Property(e => e.CreatedPhysicsId)
                    .HasColumnName("createdPhysicsID")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.Xml)
                    .HasColumnName("xml")
                    .HasColumnType("text_8");
            });

            modelBuilder.Entity<ModuleComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AssembledEffectId)
                    .HasColumnName("assembledEffectID")
                    .HasColumnType("int32");

                entity.Property(e => e.BuildType)
                    .HasColumnName("buildType")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.PartCode)
                    .HasColumnName("partCode")
                    .HasColumnType("int32");

                entity.Property(e => e.PrimarySoundGuid)
                    .HasColumnName("primarySoundGUID")
                    .HasColumnType("text_4");

                entity.Property(e => e.Xml)
                    .HasColumnName("xml")
                    .HasColumnType("text_8");
            });

            modelBuilder.Entity<MotionFx>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MotionFX");

                entity.Property(e => e.AddVelocity).HasColumnName("addVelocity");

                entity.Property(e => e.DestGroupName)
                    .HasColumnName("destGroupName")
                    .HasColumnType("text_4");

                entity.Property(e => e.Distance).HasColumnName("distance");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.EndScale).HasColumnName("endScale");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.SlamVelocity).HasColumnName("slamVelocity");

                entity.Property(e => e.StartScale).HasColumnName("startScale");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .HasColumnType("int32");

                entity.Property(e => e.Velocity).HasColumnName("velocity");
            });

            modelBuilder.Entity<MovementAicomponent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MovementAIComponent");

                entity.Property(e => e.AttachedPath)
                    .HasColumnName("attachedPath")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.MovementType).HasColumnType("text_4");
            });

            modelBuilder.Entity<MovingPlatforms>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.PlatformIsSimpleMover)
                    .HasColumnName("platformIsSimpleMover")
                    .HasColumnType("int_bool");

                entity.Property(e => e.PlatformMoveTime).HasColumnName("platformMoveTime");

                entity.Property(e => e.PlatformMoveX).HasColumnName("platformMoveX");

                entity.Property(e => e.PlatformMoveY).HasColumnName("platformMoveY");

                entity.Property(e => e.PlatformMoveZ).HasColumnName("platformMoveZ");

                entity.Property(e => e.PlatformStartAtEnd)
                    .HasColumnName("platformStartAtEnd")
                    .HasColumnType("int_bool");
            });

            modelBuilder.Entity<NpcIcons>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasColumnType("int32");

                entity.Property(e => e.CompositeConnectionNode)
                    .HasColumnName("compositeConnectionNode")
                    .HasColumnType("text_4");

                entity.Property(e => e.CompositeHorizOffset).HasColumnName("compositeHorizOffset");

                entity.Property(e => e.CompositeIconTexture)
                    .HasColumnName("compositeIconTexture")
                    .HasColumnType("text_4");

                entity.Property(e => e.CompositeLotmultiMission)
                    .HasColumnName("compositeLOTMultiMission")
                    .HasColumnType("int32");

                entity.Property(e => e.CompositeLotmultiMissionVentor)
                    .HasColumnName("compositeLOTMultiMissionVentor")
                    .HasColumnType("int32");

                entity.Property(e => e.CompositeScale).HasColumnName("compositeScale");

                entity.Property(e => e.CompositeVertOffset).HasColumnName("compositeVertOffset");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.IsClickable)
                    .HasColumnName("isClickable")
                    .HasColumnType("int_bool");

                entity.Property(e => e.Lot)
                    .HasColumnName("LOT")
                    .HasColumnType("int32");

                entity.Property(e => e.Offset).HasColumnName("offset");

                entity.Property(e => e.RotateToFace)
                    .HasColumnName("rotateToFace")
                    .HasColumnType("int_bool");

                entity.Property(e => e.Scale).HasColumnName("scale");

                entity.Property(e => e.Texture).HasColumnType("text_4");
            });

            modelBuilder.Entity<ObjectBehaviorXref>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ObjectBehaviorXREF");

                entity.Property(e => e.BehaviorId1)
                    .HasColumnName("behaviorID1")
                    .HasColumnType("int64");

                entity.Property(e => e.BehaviorId2)
                    .HasColumnName("behaviorID2")
                    .HasColumnType("int64");

                entity.Property(e => e.BehaviorId3)
                    .HasColumnName("behaviorID3")
                    .HasColumnType("int64");

                entity.Property(e => e.BehaviorId4)
                    .HasColumnName("behaviorID4")
                    .HasColumnType("int64");

                entity.Property(e => e.BehaviorId5)
                    .HasColumnName("behaviorID5")
                    .HasColumnType("int64");

                entity.Property(e => e.Lot)
                    .HasColumnName("LOT")
                    .HasColumnType("int32");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<ObjectBehaviors>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BehaviorId)
                    .HasColumnName("BehaviorID")
                    .HasColumnType("int64");

                entity.Property(e => e.Xmldata)
                    .HasColumnName("xmldata")
                    .HasColumnType("text_8");
            });

            modelBuilder.Entity<ObjectSkills>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AicombatWeight)
                    .HasColumnName("AICombatWeight")
                    .HasColumnType("int32");

                entity.Property(e => e.CastOnType)
                    .HasColumnName("castOnType")
                    .HasColumnType("int32");

                entity.Property(e => e.ObjectTemplate)
                    .HasColumnName("objectTemplate")
                    .HasColumnType("int32");

                entity.Property(e => e.SkillId)
                    .HasColumnName("skillID")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<Objects>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text_4");

                entity.Property(e => e.DisplayName)
                    .HasColumnName("displayName")
                    .HasColumnType("text_4");

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.HqValid)
                    .HasColumnName("HQ_valid")
                    .HasColumnType("int_bool");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.InteractionDistance).HasColumnName("interactionDistance");

                entity.Property(e => e.InternalNotes)
                    .HasColumnName("_internalNotes")
                    .HasColumnType("text_4");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.Localize)
                    .HasColumnName("localize")
                    .HasColumnType("int_bool");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("text_4");

                entity.Property(e => e.Nametag)
                    .HasColumnName("nametag")
                    .HasColumnType("int_bool");

                entity.Property(e => e.NpcTemplateId)
                    .HasColumnName("npcTemplateID")
                    .HasColumnType("int32");

                entity.Property(e => e.Placeable)
                    .HasColumnName("placeable")
                    .HasColumnType("int_bool");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("text_4");
            });

            modelBuilder.Entity<PackageComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.LootMatrixIndex).HasColumnType("int32");

                entity.Property(e => e.PackageType)
                    .HasColumnName("packageType")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<PetAbilities>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AbilityName).HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.ImaginationCost).HasColumnType("int32");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<PetComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AudioMetaEventSet).HasColumnType("text_4");

                entity.Property(e => e.BuffIds)
                    .HasColumnName("buffIDs")
                    .HasColumnType("text_4");

                entity.Property(e => e.ElementType)
                    .HasColumnName("elementType")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.IdleTimeMax).HasColumnName("idleTimeMax");

                entity.Property(e => e.IdleTimeMin).HasColumnName("idleTimeMin");

                entity.Property(e => e.ImaginationDrainRate).HasColumnName("imaginationDrainRate");

                entity.Property(e => e.MaxTameUpdateTime).HasColumnName("maxTameUpdateTime");

                entity.Property(e => e.MinTameUpdateTime).HasColumnName("minTameUpdateTime");

                entity.Property(e => e.PercentTameChance).HasColumnName("percentTameChance");

                entity.Property(e => e.PetForm)
                    .HasColumnName("petForm")
                    .HasColumnType("int32");

                entity.Property(e => e.RunSpeed).HasColumnName("runSpeed");

                entity.Property(e => e.SprintSpeed).HasColumnName("sprintSpeed");

                entity.Property(e => e.Tamability).HasColumnName("tamability");

                entity.Property(e => e.WalkSpeed).HasColumnName("walkSpeed");
            });

            modelBuilder.Entity<PetNestComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ElementalType).HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<PhysicsComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AirSpeed).HasColumnName("airSpeed");

                entity.Property(e => e.BoundaryAsset)
                    .HasColumnName("boundaryAsset")
                    .HasColumnType("text_4");

                entity.Property(e => e.CollisionGroup)
                    .HasColumnName("collisionGroup")
                    .HasColumnType("int32");

                entity.Property(e => e.Doublejump).HasColumnName("doublejump");

                entity.Property(e => e.Friction).HasColumnName("friction");

                entity.Property(e => e.GravityVolumeAsset)
                    .HasColumnName("gravityVolumeAsset")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.Jump).HasColumnName("jump");

                entity.Property(e => e.JumpAirSpeed).HasColumnName("jumpAirSpeed");

                entity.Property(e => e.PcShapeType)
                    .HasColumnName("pcShapeType")
                    .HasColumnType("int32");

                entity.Property(e => e.PhysicsAsset)
                    .HasColumnName("physics_asset")
                    .HasColumnType("text_4");

                entity.Property(e => e.PlayerHeight).HasColumnName("playerHeight");

                entity.Property(e => e.PlayerRadius).HasColumnName("playerRadius");

                entity.Property(e => e.RotSpeed).HasColumnName("rotSpeed");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.Static).HasColumnName("static");
            });

            modelBuilder.Entity<PlayerFlags>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.OnlySetByServer).HasColumnType("int_bool");

                entity.Property(e => e.SessionOnly).HasColumnType("int_bool");

                entity.Property(e => e.SessionZoneOnly).HasColumnType("int_bool");
            });

            modelBuilder.Entity<PlayerStatistics>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("sortOrder")
                    .HasColumnType("int32");

                entity.Property(e => e.StatId)
                    .HasColumnName("statID")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<PossessableComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AttachOffsetFwd).HasColumnName("attachOffsetFwd");

                entity.Property(e => e.AttachOffsetRight).HasColumnName("attachOffsetRight");

                entity.Property(e => e.BillboardOffsetUp).HasColumnName("billboardOffsetUp");

                entity.Property(e => e.ControlSchemeId)
                    .HasColumnName("controlSchemeID")
                    .HasColumnType("int32");

                entity.Property(e => e.DepossessOnHit)
                    .HasColumnName("depossessOnHit")
                    .HasColumnType("int_bool");

                entity.Property(e => e.HitStunTime).HasColumnName("hitStunTime");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.MinifigAttachAnimation)
                    .HasColumnName("minifigAttachAnimation")
                    .HasColumnType("text_4");

                entity.Property(e => e.MinifigAttachPoint)
                    .HasColumnName("minifigAttachPoint")
                    .HasColumnType("text_4");

                entity.Property(e => e.MinifigDetachAnimation)
                    .HasColumnName("minifigDetachAnimation")
                    .HasColumnType("text_4");

                entity.Property(e => e.MountAttachAnimation)
                    .HasColumnName("mountAttachAnimation")
                    .HasColumnType("text_4");

                entity.Property(e => e.MountDetachAnimation)
                    .HasColumnName("mountDetachAnimation")
                    .HasColumnType("text_4");

                entity.Property(e => e.PossessionType)
                    .HasColumnName("possessionType")
                    .HasColumnType("int32");

                entity.Property(e => e.SkillSet)
                    .HasColumnName("skillSet")
                    .HasColumnType("int32");

                entity.Property(e => e.WantBillboard)
                    .HasColumnName("wantBillboard")
                    .HasColumnType("int_bool");
            });

            modelBuilder.Entity<Preconditions>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.IconId)
                    .HasColumnName("iconID")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.Localize)
                    .HasColumnName("localize")
                    .HasColumnType("int_bool");

                entity.Property(e => e.TargetCount)
                    .HasColumnName("targetCount")
                    .HasColumnType("int32");

                entity.Property(e => e.TargetGroup)
                    .HasColumnName("targetGroup")
                    .HasColumnType("text_4");

                entity.Property(e => e.TargetLot)
                    .HasColumnName("targetLOT")
                    .HasColumnType("text_4");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int32");

                entity.Property(e => e.ValidContexts)
                    .HasColumnName("validContexts")
                    .HasColumnType("int64");
            });

            modelBuilder.Entity<PropertyEntranceComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GroupType)
                    .HasColumnName("groupType")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.IsOnProperty)
                    .HasColumnName("isOnProperty")
                    .HasColumnType("int_bool");

                entity.Property(e => e.MapId)
                    .HasColumnName("mapID")
                    .HasColumnType("int32");

                entity.Property(e => e.PropertyName)
                    .HasColumnName("propertyName")
                    .HasColumnType("text_4");
            });

            modelBuilder.Entity<PropertyTemplate>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AchievementRequired)
                    .HasColumnName("achievementRequired")
                    .HasColumnType("int32");

                entity.Property(e => e.CloneLimit)
                    .HasColumnName("cloneLimit")
                    .HasColumnType("int32");

                entity.Property(e => e.DurationType)
                    .HasColumnName("durationType")
                    .HasColumnType("int32");

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.Localize)
                    .HasColumnName("localize")
                    .HasColumnType("int_bool");

                entity.Property(e => e.MapId)
                    .HasColumnName("mapID")
                    .HasColumnType("int32");

                entity.Property(e => e.MaxBuildHeight).HasColumnName("maxBuildHeight");

                entity.Property(e => e.MinimumPrice)
                    .HasColumnName("minimumPrice")
                    .HasColumnType("int32");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasColumnType("text_4");

                entity.Property(e => e.RentDuration)
                    .HasColumnName("rentDuration")
                    .HasColumnType("int32");

                entity.Property(e => e.ReputationPerMinute)
                    .HasColumnName("reputationPerMinute")
                    .HasColumnType("int32");

                entity.Property(e => e.Sizecode)
                    .HasColumnName("sizecode")
                    .HasColumnType("int32");

                entity.Property(e => e.SpawnName)
                    .HasColumnName("spawnName")
                    .HasColumnType("text_4");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int32");

                entity.Property(e => e.VendorMapId)
                    .HasColumnName("vendorMapID")
                    .HasColumnType("int32");

                entity.Property(e => e.ZoneX).HasColumnName("zoneX");

                entity.Property(e => e.ZoneY).HasColumnName("zoneY");

                entity.Property(e => e.ZoneZ).HasColumnName("zoneZ");
            });

            modelBuilder.Entity<ProximityMonitorComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.LoadOnClient).HasColumnType("int_bool");

                entity.Property(e => e.LoadOnServer).HasColumnType("int_bool");

                entity.Property(e => e.Proximities).HasColumnType("text_4");
            });

            modelBuilder.Entity<ProximityTypes>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CollisionGroup).HasColumnType("int32");

                entity.Property(e => e.IconId)
                    .HasColumnName("IconID")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.LoadOnClient).HasColumnType("int_bool");

                entity.Property(e => e.LoadOnServer).HasColumnType("int_bool");

                entity.Property(e => e.Name).HasColumnType("text_4");

                entity.Property(e => e.PassiveChecks).HasColumnType("int_bool");

                entity.Property(e => e.Radius).HasColumnType("int32");
            });

            modelBuilder.Entity<RacingModuleComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Acceleration).HasColumnName("acceleration");

                entity.Property(e => e.Handling).HasColumnName("handling");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.Imagination).HasColumnName("imagination");

                entity.Property(e => e.Stability).HasColumnName("stability");

                entity.Property(e => e.TopSpeed).HasColumnName("topSpeed");
            });

            modelBuilder.Entity<RailActivatorComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CameraLocked)
                    .HasColumnName("cameraLocked")
                    .HasColumnType("int_bool");

                entity.Property(e => e.DamageImmune).HasColumnType("int_bool");

                entity.Property(e => e.EffectIds)
                    .HasColumnName("effectIDs")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.LoopAnim)
                    .HasColumnName("loopAnim")
                    .HasColumnType("text_4");

                entity.Property(e => e.LoopSound)
                    .HasColumnName("loopSound")
                    .HasColumnType("text_4");

                entity.Property(e => e.NoAggro).HasColumnType("int_bool");

                entity.Property(e => e.PlayerCollision)
                    .HasColumnName("playerCollision")
                    .HasColumnType("int_bool");

                entity.Property(e => e.Preconditions)
                    .HasColumnName("preconditions")
                    .HasColumnType("text_4");

                entity.Property(e => e.ShowNameBillboard).HasColumnType("int_bool");

                entity.Property(e => e.StartAnim)
                    .HasColumnName("startAnim")
                    .HasColumnType("text_4");

                entity.Property(e => e.StartEffectId)
                    .HasColumnName("StartEffectID")
                    .HasColumnType("text_4");

                entity.Property(e => e.StartSound)
                    .HasColumnName("startSound")
                    .HasColumnType("text_4");

                entity.Property(e => e.StopAnim)
                    .HasColumnName("stopAnim")
                    .HasColumnType("text_4");

                entity.Property(e => e.StopEffectId)
                    .HasColumnName("StopEffectID")
                    .HasColumnType("text_4");

                entity.Property(e => e.StopSound)
                    .HasColumnName("stopSound")
                    .HasColumnType("text_4");
            });

            modelBuilder.Entity<RarityTable>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.Randmax).HasColumnName("randmax");

                entity.Property(e => e.Rarity)
                    .HasColumnName("rarity")
                    .HasColumnType("int32");

                entity.Property(e => e.RarityTableIndex).HasColumnType("int32");
            });

            modelBuilder.Entity<RarityTableIndex>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.RarityTableIndex1)
                    .HasColumnName("RarityTableIndex")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<RebuildComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ActivityId)
                    .HasColumnName("activityID")
                    .HasColumnType("int32");

                entity.Property(e => e.CompleteTime).HasColumnName("complete_time");

                entity.Property(e => e.CustomModules)
                    .HasColumnName("custom_modules")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.Interruptible)
                    .HasColumnName("interruptible")
                    .HasColumnType("int_bool");

                entity.Property(e => e.PostImaginationCost)
                    .HasColumnName("post_imagination_cost")
                    .HasColumnType("int32");

                entity.Property(e => e.ResetTime).HasColumnName("reset_time");

                entity.Property(e => e.SelfActivator)
                    .HasColumnName("self_activator")
                    .HasColumnType("int_bool");

                entity.Property(e => e.TakeImagination)
                    .HasColumnName("take_imagination")
                    .HasColumnType("int32");

                entity.Property(e => e.TimeBeforeSmash).HasColumnName("time_before_smash");
            });

            modelBuilder.Entity<RebuildSections>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BPlaced)
                    .HasColumnName("bPlaced")
                    .HasColumnType("int_bool");

                entity.Property(e => e.FallAngleX).HasColumnName("fall_angle_x");

                entity.Property(e => e.FallAngleY).HasColumnName("fall_angle_y");

                entity.Property(e => e.FallAngleZ).HasColumnName("fall_angle_z");

                entity.Property(e => e.FallHeight).HasColumnName("fall_height");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("objectID")
                    .HasColumnType("int32");

                entity.Property(e => e.OffsetX).HasColumnName("offset_x");

                entity.Property(e => e.OffsetY).HasColumnName("offset_y");

                entity.Property(e => e.OffsetZ).HasColumnName("offset_z");

                entity.Property(e => e.RebuildId)
                    .HasColumnName("rebuildID")
                    .HasColumnType("int32");

                entity.Property(e => e.RequiresList)
                    .HasColumnName("requires_list")
                    .HasColumnType("text_4");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<ReleaseVersion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Release_Version");

                entity.Property(e => e.ReleaseDate).HasColumnType("int64");

                entity.Property(e => e.ReleaseVersion1)
                    .HasColumnName("ReleaseVersion")
                    .HasColumnType("text_4");
            });

            modelBuilder.Entity<RenderComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AnimationFlag)
                    .HasColumnName("animationFlag")
                    .HasColumnType("int32");

                entity.Property(e => e.AnimationGroupIds)
                    .HasColumnName("animationGroupIDs")
                    .HasColumnType("text_4");

                entity.Property(e => e.AttachIndicatorsToNode)
                    .HasColumnName("attachIndicatorsToNode")
                    .HasColumnType("int_bool");

                entity.Property(e => e.AudioMetaEventSet).HasColumnType("text_4");

                entity.Property(e => e.BillboardHeight).HasColumnName("billboardHeight");

                entity.Property(e => e.ChatBubbleOffset).HasColumnName("chatBubbleOffset");

                entity.Property(e => e.Effect1)
                    .HasColumnName("effect1")
                    .HasColumnType("int32");

                entity.Property(e => e.Effect2)
                    .HasColumnName("effect2")
                    .HasColumnType("int32");

                entity.Property(e => e.Effect3)
                    .HasColumnName("effect3")
                    .HasColumnType("int32");

                entity.Property(e => e.Effect4)
                    .HasColumnName("effect4")
                    .HasColumnType("int32");

                entity.Property(e => e.Effect5)
                    .HasColumnName("effect5")
                    .HasColumnType("int32");

                entity.Property(e => e.Effect6)
                    .HasColumnName("effect6")
                    .HasColumnType("int32");

                entity.Property(e => e.Fade)
                    .HasColumnName("fade")
                    .HasColumnType("int_bool");

                entity.Property(e => e.FadeInTime).HasColumnName("fadeInTime");

                entity.Property(e => e.GradualSnap)
                    .HasColumnName("gradualSnap")
                    .HasColumnType("int_bool");

                entity.Property(e => e.IconAsset)
                    .HasColumnName("icon_asset")
                    .HasColumnType("text_4");

                entity.Property(e => e.IconId)
                    .HasColumnName("IconID")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.IgnoreCameraCollision)
                    .HasColumnName("ignoreCameraCollision")
                    .HasColumnType("int_bool");

                entity.Property(e => e.Lxfmlfolder)
                    .HasColumnName("LXFMLFolder")
                    .HasColumnType("text_4");

                entity.Property(e => e.MaxShadowDistance).HasColumnName("maxShadowDistance");

                entity.Property(e => e.PreloadAnimations)
                    .HasColumnName("preloadAnimations")
                    .HasColumnType("int_bool");

                entity.Property(e => e.RenderAsset)
                    .HasColumnName("render_asset")
                    .HasColumnType("text_4");

                entity.Property(e => e.RenderComponentLod1)
                    .HasColumnName("renderComponentLOD1")
                    .HasColumnType("int32");

                entity.Property(e => e.RenderComponentLod2)
                    .HasColumnName("renderComponentLOD2")
                    .HasColumnType("int32");

                entity.Property(e => e.ShaderId)
                    .HasColumnName("shader_id")
                    .HasColumnType("int32");

                entity.Property(e => e.StaticBillboard)
                    .HasColumnName("staticBillboard")
                    .HasColumnType("int_bool");

                entity.Property(e => e.Usedropshadow)
                    .HasColumnName("usedropshadow")
                    .HasColumnType("int_bool");
            });

            modelBuilder.Entity<RenderComponentFlash>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Animated)
                    .HasColumnName("animated")
                    .HasColumnType("int_bool");

                entity.Property(e => e.ElementName)
                    .HasColumnName("elementName")
                    .HasColumnType("text_4");

                entity.Property(e => e.FlashPath)
                    .HasColumnName("flashPath")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.Interactive)
                    .HasColumnName("interactive")
                    .HasColumnType("int_bool");

                entity.Property(e => e.NodeName)
                    .HasColumnName("nodeName")
                    .HasColumnType("text_4");

                entity.Property(e => e.Uid)
                    .HasColumnName("_uid")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<RenderComponentWrapper>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DefaultWrapperAsset)
                    .HasColumnName("defaultWrapperAsset")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<RenderIconAssets>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BlankColumn)
                    .HasColumnName("blank_column")
                    .HasColumnType("text_4");

                entity.Property(e => e.IconAsset)
                    .HasColumnName("icon_asset")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<ReputationRewards>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.RepLevel)
                    .HasColumnName("repLevel")
                    .HasColumnType("int32");

                entity.Property(e => e.Reputation).HasColumnName("reputation");

                entity.Property(e => e.Sublevel)
                    .HasColumnName("sublevel")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<RewardCodes>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AttachmentLot)
                    .HasColumnName("attachmentLOT")
                    .HasColumnType("int32");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("text_4");

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<Rewards>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.LevelId)
                    .HasColumnName("LevelID")
                    .HasColumnType("int32");

                entity.Property(e => e.MissionId)
                    .HasColumnName("MissionID")
                    .HasColumnType("int32");

                entity.Property(e => e.RewardType).HasColumnType("int32");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<RocketLaunchpadControlComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AltLandingPrecondition)
                    .HasColumnName("altLandingPrecondition")
                    .HasColumnType("text_4");

                entity.Property(e => e.AltLandingSpawnPointName)
                    .HasColumnName("altLandingSpawnPointName")
                    .HasColumnType("text_4");

                entity.Property(e => e.DefaultZoneId)
                    .HasColumnName("defaultZoneID")
                    .HasColumnType("int32");

                entity.Property(e => e.GmLevel)
                    .HasColumnName("gmLevel")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.LaunchMusic)
                    .HasColumnName("launchMusic")
                    .HasColumnType("text_4");

                entity.Property(e => e.LaunchPrecondition)
                    .HasColumnName("launchPrecondition")
                    .HasColumnType("text_4");

                entity.Property(e => e.PlayerAnimation)
                    .HasColumnName("playerAnimation")
                    .HasColumnType("text_4");

                entity.Property(e => e.RocketAnimation)
                    .HasColumnName("rocketAnimation")
                    .HasColumnType("text_4");

                entity.Property(e => e.TargetScene)
                    .HasColumnName("targetScene")
                    .HasColumnType("text_4");

                entity.Property(e => e.TargetZone)
                    .HasColumnName("targetZone")
                    .HasColumnType("int32");

                entity.Property(e => e.UseAltLandingPrecondition)
                    .HasColumnName("useAltLandingPrecondition")
                    .HasColumnType("int_bool");

                entity.Property(e => e.UseLaunchPrecondition)
                    .HasColumnName("useLaunchPrecondition")
                    .HasColumnType("int_bool");
            });

            modelBuilder.Entity<SceneTable>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SceneId)
                    .HasColumnName("sceneID")
                    .HasColumnType("int32");

                entity.Property(e => e.SceneName)
                    .HasColumnName("sceneName")
                    .HasColumnType("text_4");
            });

            modelBuilder.Entity<ScriptComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ClientScriptName)
                    .HasColumnName("client_script_name")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.ScriptName)
                    .HasColumnName("script_name")
                    .HasColumnType("text_4");
            });

            modelBuilder.Entity<SkillBehavior>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ArmorBonusUi)
                    .HasColumnName("armorBonusUI")
                    .HasColumnType("int32");

                entity.Property(e => e.BehaviorId)
                    .HasColumnName("behaviorID")
                    .HasColumnType("int32");

                entity.Property(e => e.CancelType)
                    .HasColumnName("cancelType")
                    .HasColumnType("int32");

                entity.Property(e => e.CastTypeDesc)
                    .HasColumnName("castTypeDesc")
                    .HasColumnType("int32");

                entity.Property(e => e.Cooldown).HasColumnName("cooldown");

                entity.Property(e => e.Cooldowngroup)
                    .HasColumnName("cooldowngroup")
                    .HasColumnType("int32");

                entity.Property(e => e.DamageUi)
                    .HasColumnName("damageUI")
                    .HasColumnType("int32");

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.HideIcon)
                    .HasColumnName("hideIcon")
                    .HasColumnType("int_bool");

                entity.Property(e => e.ImBonusUi)
                    .HasColumnName("imBonusUI")
                    .HasColumnType("int32");

                entity.Property(e => e.Imaginationcost)
                    .HasColumnName("imaginationcost")
                    .HasColumnType("int32");

                entity.Property(e => e.InNpcEditor)
                    .HasColumnName("inNpcEditor")
                    .HasColumnType("int_bool");

                entity.Property(e => e.LifeBonusUi)
                    .HasColumnName("lifeBonusUI")
                    .HasColumnType("int32");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.Localize)
                    .HasColumnName("localize")
                    .HasColumnType("int_bool");

                entity.Property(e => e.OomBehaviorEffectId)
                    .HasColumnName("oomBehaviorEffectID")
                    .HasColumnType("int32");

                entity.Property(e => e.OomSkillId)
                    .HasColumnName("oomSkillID")
                    .HasColumnType("text_4");

                entity.Property(e => e.SkillIcon)
                    .HasColumnName("skillIcon")
                    .HasColumnType("int32");

                entity.Property(e => e.SkillId)
                    .HasColumnName("skillID")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<SmashableChain>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ChainIndex)
                    .HasColumnName("chainIndex")
                    .HasColumnType("int32");

                entity.Property(e => e.ChainLevel)
                    .HasColumnName("chainLevel")
                    .HasColumnType("int32");

                entity.Property(e => e.ChainStepId)
                    .HasColumnName("chainStepID")
                    .HasColumnType("int32");

                entity.Property(e => e.CurrencyIndex)
                    .HasColumnName("currencyIndex")
                    .HasColumnType("int32");

                entity.Property(e => e.CurrencyLevel)
                    .HasColumnName("currencyLevel")
                    .HasColumnType("int32");

                entity.Property(e => e.LootMatrixId)
                    .HasColumnName("lootMatrixID")
                    .HasColumnType("int32");

                entity.Property(e => e.RarityTableIndex)
                    .HasColumnName("rarityTableIndex")
                    .HasColumnType("int32");

                entity.Property(e => e.SmashCount)
                    .HasColumnName("smashCount")
                    .HasColumnType("int32");

                entity.Property(e => e.TimeLimit)
                    .HasColumnName("timeLimit")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<SmashableChainIndex>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Continuous)
                    .HasColumnName("continuous")
                    .HasColumnType("int32");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.TargetGroup)
                    .HasColumnName("targetGroup")
                    .HasColumnType("text_4");
            });

            modelBuilder.Entity<SmashableComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.LootMatrixIndex).HasColumnType("int32");
            });

            modelBuilder.Entity<SmashableElements>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DropWeight)
                    .HasColumnName("dropWeight")
                    .HasColumnType("int32");

                entity.Property(e => e.ElementId)
                    .HasColumnName("elementID")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<SpeedchatMenu>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EmoteId)
                    .HasColumnName("emoteId")
                    .HasColumnType("int32");

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.ImageName)
                    .HasColumnName("imageName")
                    .HasColumnType("text_4");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.Localize)
                    .HasColumnName("localize")
                    .HasColumnType("int_bool");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parentId")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<SubscriptionPricing>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CountryCode)
                    .HasColumnName("countryCode")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.MonetarySymbol)
                    .HasColumnName("monetarySymbol")
                    .HasColumnType("int32");

                entity.Property(e => e.MonthlyFeeBronze)
                    .HasColumnName("monthlyFeeBronze")
                    .HasColumnType("text_4");

                entity.Property(e => e.MonthlyFeeGold)
                    .HasColumnName("monthlyFeeGold")
                    .HasColumnType("text_4");

                entity.Property(e => e.MonthlyFeeSilver)
                    .HasColumnName("monthlyFeeSilver")
                    .HasColumnType("text_4");

                entity.Property(e => e.SymbolIsAppended)
                    .HasColumnName("symbolIsAppended")
                    .HasColumnType("int_bool");
            });

            modelBuilder.Entity<SurfaceType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FootstepNdaudioMetaEventSetName)
                    .HasColumnName("FootstepNDAudioMetaEventSetName")
                    .HasColumnType("text_4");

                entity.Property(e => e.SurfaceType1)
                    .HasColumnName("SurfaceType")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<Sysdiagrams>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sysdiagrams");

                entity.Property(e => e.Definition)
                    .HasColumnName("definition")
                    .HasColumnType("text_4");

                entity.Property(e => e.DiagramId)
                    .HasColumnName("diagram_id")
                    .HasColumnType("int32");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("text_4");

                entity.Property(e => e.PrincipalId)
                    .HasColumnName("principal_id")
                    .HasColumnType("int32");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<TamingBuildPuzzles>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Difficulty).HasColumnType("int32");

                entity.Property(e => e.FullModelLxf)
                    .HasColumnName("FullModelLXF")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.ImagCostPerBuild)
                    .HasColumnName("imagCostPerBuild")
                    .HasColumnType("int32");

                entity.Property(e => e.InvalidPiecesLxf)
                    .HasColumnName("InvalidPiecesLXF")
                    .HasColumnType("text_4");

                entity.Property(e => e.ModelName).HasColumnType("text_4");

                entity.Property(e => e.Npclot)
                    .HasColumnName("NPCLot")
                    .HasColumnType("int32");

                entity.Property(e => e.NumValidPieces).HasColumnType("int32");

                entity.Property(e => e.PuzzleModelLot).HasColumnType("int32");

                entity.Property(e => e.Timelimit).HasColumnType("int32");

                entity.Property(e => e.TotalNumPieces).HasColumnType("int32");

                entity.Property(e => e.ValidPiecesLxf)
                    .HasColumnName("ValidPiecesLXF")
                    .HasColumnType("text_4");
            });

            modelBuilder.Entity<TextDescription>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.TestDescription).HasColumnType("text_4");

                entity.Property(e => e.TextId)
                    .HasColumnName("TextID")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<TextLanguage>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasColumnType("int32");

                entity.Property(e => e.Text).HasColumnType("text_4");

                entity.Property(e => e.TextId)
                    .HasColumnName("TextID")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<TrailEffects>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BirthDelay).HasColumnName("birthDelay");

                entity.Property(e => e.Blendmode)
                    .HasColumnName("blendmode")
                    .HasColumnType("int32");

                entity.Property(e => e.Bone1)
                    .HasColumnName("bone1")
                    .HasColumnType("text_4");

                entity.Property(e => e.Bone2)
                    .HasColumnName("bone2")
                    .HasColumnType("text_4");

                entity.Property(e => e.Cardlifetime).HasColumnName("cardlifetime");

                entity.Property(e => e.Colorlifetime).HasColumnName("colorlifetime");

                entity.Property(e => e.DeathDelay).HasColumnName("deathDelay");

                entity.Property(e => e.EndColorA).HasColumnName("endColorA");

                entity.Property(e => e.EndColorB).HasColumnName("endColorB");

                entity.Property(e => e.EndColorG).HasColumnName("endColorG");

                entity.Property(e => e.EndColorR).HasColumnName("endColorR");

                entity.Property(e => e.MaxParticles)
                    .HasColumnName("max_particles")
                    .HasColumnType("int32");

                entity.Property(e => e.MiddleColorA).HasColumnName("middleColorA");

                entity.Property(e => e.MiddleColorB).HasColumnName("middleColorB");

                entity.Property(e => e.MiddleColorG).HasColumnName("middleColorG");

                entity.Property(e => e.MiddleColorR).HasColumnName("middleColorR");

                entity.Property(e => e.MinTailFade).HasColumnName("minTailFade");

                entity.Property(e => e.StartColorA).HasColumnName("startColorA");

                entity.Property(e => e.StartColorB).HasColumnName("startColorB");

                entity.Property(e => e.StartColorG).HasColumnName("startColorG");

                entity.Property(e => e.StartColorR).HasColumnName("startColorR");

                entity.Property(e => e.TailFade).HasColumnName("tailFade");

                entity.Property(e => e.TexLength).HasColumnName("texLength");

                entity.Property(e => e.TexWidth).HasColumnName("texWidth");

                entity.Property(e => e.TextureName)
                    .HasColumnName("textureName")
                    .HasColumnType("text_4");

                entity.Property(e => e.TrailId)
                    .HasColumnName("trailID")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<UgbehaviorSounds>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UGBehaviorSounds");

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.Localize)
                    .HasColumnName("localize")
                    .HasColumnType("int_bool");
            });

            modelBuilder.Entity<VehiclePhysics>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AudioEventEngine).HasColumnType("text_4");

                entity.Property(e => e.AudioEventHeavyHit).HasColumnType("text_4");

                entity.Property(e => e.AudioEventHeavyLand).HasColumnType("text_4");

                entity.Property(e => e.AudioEventLightHit).HasColumnType("text_4");

                entity.Property(e => e.AudioEventLightLand).HasColumnType("text_4");

                entity.Property(e => e.AudioEventSkid).HasColumnType("text_4");

                entity.Property(e => e.AudioEventStart).HasColumnType("text_4");

                entity.Property(e => e.AudioEventTreadConcrete).HasColumnType("text_4");

                entity.Property(e => e.AudioEventTreadDirt).HasColumnType("text_4");

                entity.Property(e => e.AudioEventTreadGrass).HasColumnType("text_4");

                entity.Property(e => e.AudioEventTreadGravel).HasColumnType("text_4");

                entity.Property(e => e.AudioEventTreadIce).HasColumnType("text_4");

                entity.Property(e => e.AudioEventTreadLeaves).HasColumnType("text_4");

                entity.Property(e => e.AudioEventTreadMetal).HasColumnType("text_4");

                entity.Property(e => e.AudioEventTreadMud).HasColumnType("text_4");

                entity.Property(e => e.AudioEventTreadPlastic).HasColumnType("text_4");

                entity.Property(e => e.AudioEventTreadSand).HasColumnType("text_4");

                entity.Property(e => e.AudioEventTreadSnow).HasColumnType("text_4");

                entity.Property(e => e.AudioEventTreadWater).HasColumnType("text_4");

                entity.Property(e => e.AudioEventTreadWood).HasColumnType("text_4");

                entity.Property(e => e.BWheelsVisible)
                    .HasColumnName("bWheelsVisible")
                    .HasColumnType("int_bool");

                entity.Property(e => e.FAeroAirDensity).HasColumnName("fAeroAirDensity");

                entity.Property(e => e.FAeroDragCoefficient).HasColumnName("fAeroDragCoefficient");

                entity.Property(e => e.FAeroExtraGravity).HasColumnName("fAeroExtraGravity");

                entity.Property(e => e.FAeroFrontalArea).HasColumnName("fAeroFrontalArea");

                entity.Property(e => e.FAeroLiftCoefficient).HasColumnName("fAeroLiftCoefficient");

                entity.Property(e => e.FBoostAccelerateChange).HasColumnName("fBoostAccelerateChange");

                entity.Property(e => e.FBoostCostPerSecond).HasColumnName("fBoostCostPerSecond");

                entity.Property(e => e.FBoostDampingChange).HasColumnName("fBoostDampingChange");

                entity.Property(e => e.FBoostTopSpeed).HasColumnName("fBoostTopSpeed");

                entity.Property(e => e.FBrakeFrontTorque).HasColumnName("fBrakeFrontTorque");

                entity.Property(e => e.FBrakeMinInputToBlock).HasColumnName("fBrakeMinInputToBlock");

                entity.Property(e => e.FBrakeMinTimeToBlock).HasColumnName("fBrakeMinTimeToBlock");

                entity.Property(e => e.FBrakeRearTorque).HasColumnName("fBrakeRearTorque");

                entity.Property(e => e.FCenterOfMassFwd).HasColumnName("fCenterOfMassFwd");

                entity.Property(e => e.FCenterOfMassRight).HasColumnName("fCenterOfMassRight");

                entity.Property(e => e.FCenterOfMassUp).HasColumnName("fCenterOfMassUp");

                entity.Property(e => e.FChassisFriction).HasColumnName("fChassisFriction");

                entity.Property(e => e.FCollisionSpinDamping).HasColumnName("fCollisionSpinDamping");

                entity.Property(e => e.FCollisionThreshold).HasColumnName("fCollisionThreshold");

                entity.Property(e => e.FEngineTorque).HasColumnName("fEngineTorque");

                entity.Property(e => e.FExtraTorqueFactor).HasColumnName("fExtraTorqueFactor");

                entity.Property(e => e.FFrontTireFriction).HasColumnName("fFrontTireFriction");

                entity.Property(e => e.FFrontTireFrictionSlide).HasColumnName("fFrontTireFrictionSlide");

                entity.Property(e => e.FFrontTireSlipAngle).HasColumnName("fFrontTireSlipAngle");

                entity.Property(e => e.FFwdBias).HasColumnName("fFwdBias");

                entity.Property(e => e.FGravityScale).HasColumnName("fGravityScale");

                entity.Property(e => e.FImaginationTankSize).HasColumnName("fImaginationTankSize");

                entity.Property(e => e.FInertiaPitch).HasColumnName("fInertiaPitch");

                entity.Property(e => e.FInertiaRoll).HasColumnName("fInertiaRoll");

                entity.Property(e => e.FInertiaYaw).HasColumnName("fInertiaYaw");

                entity.Property(e => e.FInputAccelSpeed).HasColumnName("fInputAccelSpeed");

                entity.Property(e => e.FInputDeadAccelDownSpeed).HasColumnName("fInputDeadAccelDownSpeed");

                entity.Property(e => e.FInputDeadDecelDownSpeed).HasColumnName("fInputDeadDecelDownSpeed");

                entity.Property(e => e.FInputDeadTurnBackSpeed).HasColumnName("fInputDeadTurnBackSpeed");

                entity.Property(e => e.FInputDeadZone).HasColumnName("fInputDeadZone");

                entity.Property(e => e.FInputDecelSpeed).HasColumnName("fInputDecelSpeed");

                entity.Property(e => e.FInputInitialSlope).HasColumnName("fInputInitialSlope");

                entity.Property(e => e.FInputSlopeChangePointX).HasColumnName("fInputSlopeChangePointX");

                entity.Property(e => e.FInputTurnSpeed).HasColumnName("fInputTurnSpeed");

                entity.Property(e => e.FMass).HasColumnName("fMass");

                entity.Property(e => e.FMaxSpeed).HasColumnName("fMaxSpeed");

                entity.Property(e => e.FNormalSpinDamping).HasColumnName("fNormalSpinDamping");

                entity.Property(e => e.FPowerslideNeutralAngle).HasColumnName("fPowerslideNeutralAngle");

                entity.Property(e => e.FPowerslideTorqueStrength).HasColumnName("fPowerslideTorqueStrength");

                entity.Property(e => e.FRearTireFriction).HasColumnName("fRearTireFriction");

                entity.Property(e => e.FRearTireFrictionSlide).HasColumnName("fRearTireFrictionSlide");

                entity.Property(e => e.FRearTireSlipAngle).HasColumnName("fRearTireSlipAngle");

                entity.Property(e => e.FReorientPitchStrength).HasColumnName("fReorientPitchStrength");

                entity.Property(e => e.FReorientRollStrength).HasColumnName("fReorientRollStrength");

                entity.Property(e => e.FSkillCost).HasColumnName("fSkillCost");

                entity.Property(e => e.FSteeringMaxAngle).HasColumnName("fSteeringMaxAngle");

                entity.Property(e => e.FSteeringMinAngle).HasColumnName("fSteeringMinAngle");

                entity.Property(e => e.FSteeringSpeedLimitForMaxAngle).HasColumnName("fSteeringSpeedLimitForMaxAngle");

                entity.Property(e => e.FSuspensionDampingCompression).HasColumnName("fSuspensionDampingCompression");

                entity.Property(e => e.FSuspensionDampingRelaxation).HasColumnName("fSuspensionDampingRelaxation");

                entity.Property(e => e.FSuspensionLength).HasColumnName("fSuspensionLength");

                entity.Property(e => e.FSuspensionStrength).HasColumnName("fSuspensionStrength");

                entity.Property(e => e.FTorquePitchFactor).HasColumnName("fTorquePitchFactor");

                entity.Property(e => e.FTorqueRollFactor).HasColumnName("fTorqueRollFactor");

                entity.Property(e => e.FTorqueYawFactor).HasColumnName("fTorqueYawFactor");

                entity.Property(e => e.FWheelHardpointFrontFwd).HasColumnName("fWheelHardpointFrontFwd");

                entity.Property(e => e.FWheelHardpointFrontRight).HasColumnName("fWheelHardpointFrontRight");

                entity.Property(e => e.FWheelHardpointFrontUp).HasColumnName("fWheelHardpointFrontUp");

                entity.Property(e => e.FWheelHardpointRearFwd).HasColumnName("fWheelHardpointRearFwd");

                entity.Property(e => e.FWheelHardpointRearRight).HasColumnName("fWheelHardpointRearRight");

                entity.Property(e => e.FWheelHardpointRearUp).HasColumnName("fWheelHardpointRearUp");

                entity.Property(e => e.FWheelMass).HasColumnName("fWheelMass");

                entity.Property(e => e.FWheelRadius).HasColumnName("fWheelRadius");

                entity.Property(e => e.FWheelWidth).HasColumnName("fWheelWidth");

                entity.Property(e => e.FWreckMinAngle).HasColumnName("fWreckMinAngle");

                entity.Property(e => e.FWreckSpeedBase).HasColumnName("fWreckSpeedBase");

                entity.Property(e => e.FWreckSpeedPercent).HasColumnName("fWreckSpeedPercent");

                entity.Property(e => e.HkxFilename)
                    .HasColumnName("hkxFilename")
                    .HasColumnType("text_4");

                entity.Property(e => e.IChassisCollisionGroup)
                    .HasColumnName("iChassisCollisionGroup")
                    .HasColumnType("int32");

                entity.Property(e => e.IPowerslideNumTorqueApplications)
                    .HasColumnName("iPowerslideNumTorqueApplications")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<VehicleStatMap>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.HavokStat).HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.ModuleStat).HasColumnType("text_4");
            });

            modelBuilder.Entity<VendorComponent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BuyScalar).HasColumnName("buyScalar");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.LootMatrixIndex).HasColumnType("int32");

                entity.Property(e => e.RefreshTimeSeconds).HasColumnName("refreshTimeSeconds");

                entity.Property(e => e.SellScalar).HasColumnName("sellScalar");
            });

            modelBuilder.Entity<WhatsCoolItemSpotlight>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemID")
                    .HasColumnType("int32");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.Localize)
                    .HasColumnName("localize")
                    .HasColumnType("int_bool");
            });

            modelBuilder.Entity<WhatsCoolNewsAndTips>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.IconId)
                    .HasColumnName("iconID")
                    .HasColumnType("int32");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.Localize)
                    .HasColumnName("localize")
                    .HasColumnType("int_bool");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<WorldConfig>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CharacterEyeHeight).HasColumnName("character_eye_height");

                entity.Property(e => e.CharacterGroundedSpeed).HasColumnName("characterGroundedSpeed");

                entity.Property(e => e.CharacterGroundedTime).HasColumnName("characterGroundedTime");

                entity.Property(e => e.CharacterMaxSlope).HasColumnName("character_max_slope");

                entity.Property(e => e.CharacterRotationSpeed).HasColumnName("character_rotation_speed");

                entity.Property(e => e.CharacterRunBackwardSpeed).HasColumnName("character_run_backward_speed");

                entity.Property(e => e.CharacterRunStrafeBackwardSpeed).HasColumnName("character_run_strafe_backward_speed");

                entity.Property(e => e.CharacterRunStrafeForwardSpeed).HasColumnName("character_run_strafe_forward_speed");

                entity.Property(e => e.CharacterRunStrafeSpeed).HasColumnName("character_run_strafe_speed");

                entity.Property(e => e.CharacterVersion).HasColumnType("int32");

                entity.Property(e => e.CharacterVotesPerDay)
                    .HasColumnName("character_votes_per_day")
                    .HasColumnType("int32");

                entity.Property(e => e.CharacterWalkBackwardSpeed).HasColumnName("character_walk_backward_speed");

                entity.Property(e => e.CharacterWalkForwardSpeed).HasColumnName("character_walk_forward_speed");

                entity.Property(e => e.CharacterWalkStrafeBackwardSpeed).HasColumnName("character_walk_strafe_backward_speed");

                entity.Property(e => e.CharacterWalkStrafeForwardSpeed).HasColumnName("character_walk_strafe_forward_speed");

                entity.Property(e => e.CharacterWalkStrafeSpeed).HasColumnName("character_walk_strafe_speed");

                entity.Property(e => e.CoinsLostOnDeathMax)
                    .HasColumnName("coins_lost_on_death_max")
                    .HasColumnType("int32");

                entity.Property(e => e.CoinsLostOnDeathMaxTimeout).HasColumnName("coins_lost_on_death_max_timeout");

                entity.Property(e => e.CoinsLostOnDeathMin)
                    .HasColumnName("coins_lost_on_death_min")
                    .HasColumnType("int32");

                entity.Property(e => e.CoinsLostOnDeathMinTimeout).HasColumnName("coins_lost_on_death_min_timeout");

                entity.Property(e => e.CoinsLostOnDeathPercent).HasColumnName("coins_lost_on_death_percent");

                entity.Property(e => e.DefaultHomespaceTemplate)
                    .HasColumnName("defaultHomespaceTemplate")
                    .HasColumnType("int32");

                entity.Property(e => e.DefaultPropertyMaxHeight).HasColumnName("defaultPropertyMaxHeight");

                entity.Property(e => e.Defaultrespawntime).HasColumnName("defaultrespawntime");

                entity.Property(e => e.FReputationPerVote).HasColumnName("fReputationPerVote");

                entity.Property(e => e.FlightAirspeed).HasColumnName("flight_airspeed");

                entity.Property(e => e.FlightFuelRatio).HasColumnName("flight_fuel_ratio");

                entity.Property(e => e.FlightMaxAirspeed).HasColumnName("flight_max_airspeed");

                entity.Property(e => e.FlightVerticalVelocity).HasColumnName("flight_vertical_velocity");

                entity.Property(e => e.GlobalCooldown).HasColumnName("global_cooldown");

                entity.Property(e => e.GlobalImmunityTime).HasColumnName("globalImmunityTime");

                entity.Property(e => e.LevelCap).HasColumnType("int32");

                entity.Property(e => e.LevelCapCurrencyConversion).HasColumnType("int32");

                entity.Property(e => e.LevelUpBehaviorEffect).HasColumnType("text_4");

                entity.Property(e => e.MailBaseFee)
                    .HasColumnName("mail_base_fee")
                    .HasColumnType("int32");

                entity.Property(e => e.MailPercentAttachmentFee).HasColumnName("mail_percent_attachment_fee");

                entity.Property(e => e.MissionTooltipTimeout).HasColumnName("mission_tooltip_timeout");

                entity.Property(e => e.ModelModerateOnCreate)
                    .HasColumnName("modelModerateOnCreate")
                    .HasColumnType("int_bool");

                entity.Property(e => e.NPropertyCloneLimit)
                    .HasColumnName("nPropertyCloneLimit")
                    .HasColumnType("int32");

                entity.Property(e => e.Pebroadphaseworldsize).HasColumnName("pebroadphaseworldsize");

                entity.Property(e => e.Pegameobjscalefactor).HasColumnName("pegameobjscalefactor");

                entity.Property(e => e.Pegravityvalue).HasColumnName("pegravityvalue");

                entity.Property(e => e.PetFollowRadius).HasColumnName("pet_follow_radius");

                entity.Property(e => e.PropertyModRequestsAllowedInterval)
                    .HasColumnName("propertyModRequestsAllowedInterval")
                    .HasColumnType("int32");

                entity.Property(e => e.PropertyModRequestsAllowedSpike)
                    .HasColumnName("propertyModRequestsAllowedSpike")
                    .HasColumnType("int32");

                entity.Property(e => e.PropertyModRequestsAllowedTotal)
                    .HasColumnName("propertyModRequestsAllowedTotal")
                    .HasColumnType("int32");

                entity.Property(e => e.PropertyModRequestsIntervalDuration)
                    .HasColumnName("propertyModRequestsIntervalDuration")
                    .HasColumnType("int32");

                entity.Property(e => e.PropertyModRequestsSpikeDuration)
                    .HasColumnName("propertyModRequestsSpikeDuration")
                    .HasColumnType("int32");

                entity.Property(e => e.PropertyModerationRequestApprovalCost)
                    .HasColumnName("property_moderation_request_approval_cost")
                    .HasColumnType("int32");

                entity.Property(e => e.PropertyModerationRequestReviewCost)
                    .HasColumnName("property_moderation_request_review_cost")
                    .HasColumnType("int32");

                entity.Property(e => e.PropertyReputationDelay)
                    .HasColumnName("propertyReputationDelay")
                    .HasColumnType("int32");

                entity.Property(e => e.ReputationPerBattlePromotion).HasColumnName("reputationPerBattlePromotion");

                entity.Property(e => e.ReputationPerVoteCast).HasColumnName("reputationPerVoteCast");

                entity.Property(e => e.ReputationPerVoteReceived).HasColumnName("reputationPerVoteReceived");

                entity.Property(e => e.ShowcaseTopModelConsiderationBattles)
                    .HasColumnName("showcaseTopModelConsiderationBattles")
                    .HasColumnType("int32");

                entity.Property(e => e.VendorBuyMultiplier).HasColumnName("vendor_buy_multiplier");

                entity.Property(e => e.WorldConfigId)
                    .HasColumnName("WorldConfigID")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<ZoneLoadingTips>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int32");

                entity.Property(e => e.Imagelocation)
                    .HasColumnName("imagelocation")
                    .HasColumnType("text_4");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.Localize)
                    .HasColumnName("localize")
                    .HasColumnType("int_bool");

                entity.Property(e => e.TargetVersion)
                    .HasColumnName("targetVersion")
                    .HasColumnType("text_4");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("int32");

                entity.Property(e => e.Zoneid)
                    .HasColumnName("zoneid")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<ZoneSummary>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int32");

                entity.Property(e => e.UniqueId)
                    .HasColumnName("_uniqueID")
                    .HasColumnType("int32");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("int32");

                entity.Property(e => e.ZoneId)
                    .HasColumnName("zoneID")
                    .HasColumnType("int32");
            });

            modelBuilder.Entity<ZoneTable>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ClientPhysicsFramerate)
                    .HasColumnName("clientPhysicsFramerate")
                    .HasColumnType("text_4");

                entity.Property(e => e.DisableSaveLoc)
                    .HasColumnName("disableSaveLoc")
                    .HasColumnType("int_bool");

                entity.Property(e => e.DisplayDescription).HasColumnType("text_4");

                entity.Property(e => e.FZoneWeight).HasColumnName("fZoneWeight");

                entity.Property(e => e.GateVersion)
                    .HasColumnName("gate_version")
                    .HasColumnType("text_4");

                entity.Property(e => e.Ghostdistance).HasColumnName("ghostdistance");

                entity.Property(e => e.GhostdistanceMin).HasColumnName("ghostdistance_min");

                entity.Property(e => e.HeightInChunks)
                    .HasColumnName("heightInChunks")
                    .HasColumnType("int32");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("locStatus")
                    .HasColumnType("int32");

                entity.Property(e => e.Localize)
                    .HasColumnName("localize")
                    .HasColumnType("int_bool");

                entity.Property(e => e.MapFolder)
                    .HasColumnName("mapFolder")
                    .HasColumnType("text_4");

                entity.Property(e => e.MixerProgram)
                    .HasColumnName("mixerProgram")
                    .HasColumnType("text_4");

                entity.Property(e => e.MountsAllowed)
                    .HasColumnName("mountsAllowed")
                    .HasColumnType("int_bool");

                entity.Property(e => e.PetsAllowed)
                    .HasColumnName("petsAllowed")
                    .HasColumnType("int_bool");

                entity.Property(e => e.PlayerLoseCoinsOnDeath).HasColumnType("int_bool");

                entity.Property(e => e.PopulationHardCap)
                    .HasColumnName("population_hard_cap")
                    .HasColumnType("int32");

                entity.Property(e => e.PopulationSoftCap)
                    .HasColumnName("population_soft_cap")
                    .HasColumnType("int32");

                entity.Property(e => e.ScriptId)
                    .HasColumnName("scriptID")
                    .HasColumnType("int32");

                entity.Property(e => e.ServerPhysicsFramerate)
                    .HasColumnName("serverPhysicsFramerate")
                    .HasColumnType("text_4");

                entity.Property(e => e.SmashableMaxDistance).HasColumnName("smashableMaxDistance");

                entity.Property(e => e.SmashableMinDistance).HasColumnName("smashableMinDistance");

                entity.Property(e => e.TeamRadius).HasColumnName("teamRadius");

                entity.Property(e => e.Thumbnail)
                    .HasColumnName("thumbnail")
                    .HasColumnType("text_4");

                entity.Property(e => e.WidthInChunks)
                    .HasColumnName("widthInChunks")
                    .HasColumnType("int32");

                entity.Property(e => e.ZoneControlTemplate)
                    .HasColumnName("zoneControlTemplate")
                    .HasColumnType("int32");

                entity.Property(e => e.ZoneId)
                    .HasColumnName("zoneID")
                    .HasColumnType("int32");

                entity.Property(e => e.ZoneName)
                    .HasColumnName("zoneName")
                    .HasColumnType("text_4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
