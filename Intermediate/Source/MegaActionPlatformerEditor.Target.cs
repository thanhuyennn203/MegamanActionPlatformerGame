using UnrealBuildTool;

public class MegaActionPlatformerEditorTarget : TargetRules
{
	public MegaActionPlatformerEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MegaActionPlatformer");
	}
}
