using System;


namespace R5T.Palembang
{
    /// <summary>
    /// Provides the project name (note, NOT the project file name).
    /// </summary>
    public interface ISolutionNameProvider
    {
        string GetSolutionName();
    }
}
