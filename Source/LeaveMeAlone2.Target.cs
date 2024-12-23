// LeaveMeAlone Game by Netologiya. All RightsReserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class LeaveMeAlone2Target : TargetRules
{
	public LeaveMeAlone2Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "LeaveMeAlone2" } );
	}
}
