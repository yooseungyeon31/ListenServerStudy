using UnrealBuildTool;

public class ListenServerStudyServerTarget : TargetRules
{
	public ListenServerStudyServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("ListenServerStudy");
	}
}
