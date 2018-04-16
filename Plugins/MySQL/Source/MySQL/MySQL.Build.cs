using UnrealBuildTool;
using System.IO;
 
public class MySQL: ModuleRules
{
    public MySQL(ReadOnlyTargetRules Target) : base(Target)
    {
        PrivateIncludePaths.AddRange(new string[]
        {
            "MySQL/Private"
               
        });

        PublicDependencyModuleNames.AddRange(new [] { "Core", "CoreUObject", "Engine", "InputCore" , "Projects"  });

        PrivateDependencyModuleNames.AddRange(new[] {"XmlParser" , "ImageWrapper", "Engine"});

        string BaseDirectory = Path.GetFullPath(Path.Combine(ModuleDirectory, "..", ".."));
        string SQLDirectory = Path.Combine(BaseDirectory, "SQLLib");

        PublicIncludePaths.Add(Path.Combine(SQLDirectory, "MySQLIntegration.dll"));
        PublicIncludePaths.Add(Path.Combine(SQLDirectory, "MySql.Data.dll"));

        RuntimeDependencies.Add(new RuntimeDependency(Path.Combine(SQLDirectory, "MySQLIntegration.dll")));
        RuntimeDependencies.Add(new RuntimeDependency(Path.Combine(SQLDirectory, "MySql.Data.dll")));

        PublicDelayLoadDLLs.Add(Path.Combine(SQLDirectory, "MySql.Data.dll"));

    }
}