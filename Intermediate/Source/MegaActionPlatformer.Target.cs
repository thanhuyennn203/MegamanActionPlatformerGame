using UnrealBuildTool;

public class MegaActionPlatformerTarget : TargetRules
{
	public MegaActionPlatformerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MegaActionPlatformer");
	}
}
