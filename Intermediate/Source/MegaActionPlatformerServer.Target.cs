using UnrealBuildTool;

public class MegaActionPlatformerServerTarget : TargetRules
{
	public MegaActionPlatformerServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MegaActionPlatformer");
	}
}
