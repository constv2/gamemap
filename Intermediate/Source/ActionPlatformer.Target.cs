using UnrealBuildTool;

public class ActionPlatformerTarget : TargetRules
{
	public ActionPlatformerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ActionPlatformer");
	}
}
