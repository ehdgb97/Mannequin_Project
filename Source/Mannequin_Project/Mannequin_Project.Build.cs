// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Mannequin_Project : ModuleRules
{
	public Mannequin_Project(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
