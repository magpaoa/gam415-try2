// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Foo : ModuleRules
{
    public Foo(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicIncludePaths.AddRange(
            new string[] {
            	// ... add public include paths required here ...
        	}
            );
        PrivateIncludePaths.AddRange(
            new string[] {
                "Foo/Private",
            	// ... add other private include paths required here ...
        	}
            );

        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
                "CoreUObject",
                "Engine",
                "RenderCore",
                "RHI",
            	// ... add other public dependencies that you statically link with here ...
        	}
            );
        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "Projects",
            	// ... add private dependencies that you statically link with here ...
        	}
            );
    }
}