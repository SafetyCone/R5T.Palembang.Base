using System;using R5T.T0064;


namespace R5T.Palembang
{
    /// <summary>
    /// Provides the project name (note, NOT the project file name).
    /// </summary>
    [ServiceDefinitionMarker]
    public interface ISolutionNameProvider:IServiceDefinition
    {
        string GetSolutionName();
    }
}
