using System;

using Microsoft.CodeAnalysis;

using Instances = R5T.S0032.F001.Instances;


namespace System
{
    public static class SyntaxNodeExtensions
    {
        public static void WriteToExampleCodeFilePath(this SyntaxNode node)
        {
            Instances.SyntaxOperator.WriteToExampleCodeFilePath(node);
        }
    }
}
