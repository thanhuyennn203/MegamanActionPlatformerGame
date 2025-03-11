using UnrealBuildTool;

public class MegaActionPlatformerClientTarget : TargetRules
{
	public MegaActionPlatformerClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MegaActionPlatformer");
	}
}
