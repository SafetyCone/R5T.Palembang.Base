using System;using R5T.T0064;


namespace R5T.Palembang
{[ServiceDefinitionMarker]
    /// <summary>
    /// Provides the project name (note, NOT the project file name).
    /// </summary>
    public interface ISolutionNameProvider:IServiceDefinition
    {
        string GetSolutionName();
    }
}
