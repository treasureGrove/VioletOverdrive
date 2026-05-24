// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class VioletOverdrive : ModuleRules
{
	public VioletOverdrive(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"VioletOverdrive",
			"VioletOverdrive/Variant_Platforming",
			"VioletOverdrive/Variant_Platforming/Animation",
			"VioletOverdrive/Variant_Combat",
			"VioletOverdrive/Variant_Combat/AI",
			"VioletOverdrive/Variant_Combat/Animation",
			"VioletOverdrive/Variant_Combat/Gameplay",
			"VioletOverdrive/Variant_Combat/Interfaces",
			"VioletOverdrive/Variant_Combat/UI",
			"VioletOverdrive/Variant_SideScrolling",
			"VioletOverdrive/Variant_SideScrolling/AI",
			"VioletOverdrive/Variant_SideScrolling/Gameplay",
			"VioletOverdrive/Variant_SideScrolling/Interfaces",
			"VioletOverdrive/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
