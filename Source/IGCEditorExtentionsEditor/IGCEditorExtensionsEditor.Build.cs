// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class IGCEditorExtensionsEditor : ModuleRules
{
	public IGCEditorExtensionsEditor(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(
			new string[] 
			{ 
				"Core", 
				"CoreUObject"
			}
		);

		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}