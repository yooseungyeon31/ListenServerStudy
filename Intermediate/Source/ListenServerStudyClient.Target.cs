using UnrealBuildTool;

public class ListenServerStudyClientTarget : TargetRules
{
	public ListenServerStudyClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("ListenServerStudy");
	}
}
