using System;using R5T.T0064;


namespace R5T.Palembang
{[ServiceDefinitionMarker]
    public interface ITargetFrameworkNameProvider:IServiceDefinition
    {
        string GetTargetFrameworkName();
    }
}
