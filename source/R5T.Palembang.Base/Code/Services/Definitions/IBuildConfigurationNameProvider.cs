using System;using R5T.T0064;


namespace R5T.Palembang
{[ServiceDefinitionMarker]
    /// <summary>
    /// Provides the build configuration name (examples: "Release", "Debug").
    /// </summary>
    public interface IBuildConfigurationNameProvider:IServiceDefinition
    {
        string GetBuildConfigurationName();
    }
}
