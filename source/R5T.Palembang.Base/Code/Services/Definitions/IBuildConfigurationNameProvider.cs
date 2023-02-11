using System;using R5T.T0064;


namespace R5T.Palembang
{
    /// <summary>
    /// Provides the build configuration name (examples: "Release", "Debug").
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IBuildConfigurationNameProvider:IServiceDefinition
    {
        string GetBuildConfigurationName();
    }
}
