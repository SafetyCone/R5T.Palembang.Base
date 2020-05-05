using System;


namespace R5T.Palembang
{
    /// <summary>
    /// Provides the build configuration name (examples: "Release", "Debug").
    /// </summary>
    public interface IBuildConfigurationNameProvider
    {
        string GetBuildConfigurationName();
    }
}
