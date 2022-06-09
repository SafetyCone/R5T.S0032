using System;

using Microsoft.CodeAnalysis;

using Instances = R5T.S0032.F001.Instances;


namespace System
{
    public static class SyntaxTokenExtensions
    {
        public static void WriteToExampleCodeFilePath(this SyntaxToken token)
        {
            Instances.SyntaxOperator.WriteToExampleCodeFilePath(token);
        }
    }
}
