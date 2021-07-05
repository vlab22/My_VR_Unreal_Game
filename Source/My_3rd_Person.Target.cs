// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class My_3rd_PersonTarget : TargetRules
{
	public My_3rd_PersonTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		
		// if (Target.Platform == UnrealTargetPlatform.Win64)
		// {
		// 	bUseLoggingInShipping = true;
		// }
		
		ExtraModuleNames.AddRange( new string[] { "My_3rd_Person" } );
	}
}
