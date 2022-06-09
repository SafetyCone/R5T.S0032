using System;

using R5T.T0132;


namespace R5T.S0032.F001
{
    [DraftFunctionalityMarker]
    public partial interface IExamples : IDraftFunctionalityMarker
    {
        public string ExampleCodeFilePath()
        {
            return @"C:\Temp\Code.cs";
        }
    }
}
