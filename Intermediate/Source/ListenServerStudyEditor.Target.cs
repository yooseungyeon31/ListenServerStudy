using UnrealBuildTool;

public class ListenServerStudyEditorTarget : TargetRules
{
	public ListenServerStudyEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ListenServerStudy");
	}
}
