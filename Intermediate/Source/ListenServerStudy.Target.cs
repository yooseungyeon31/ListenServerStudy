using UnrealBuildTool;

public class ListenServerStudyTarget : TargetRules
{
	public ListenServerStudyTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ListenServerStudy");
	}
}
