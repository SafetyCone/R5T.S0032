using System;

using Microsoft.CodeAnalysis;

using Instances = R5T.S0032.F001.Instances;


namespace System
{
    public static class SyntaxTriviaExtensions
    {
        public static void WriteToExampleCodeFilePath(this SyntaxTrivia trivia)
        {
            Instances.SyntaxOperator.WriteToExampleCodeFilePath(trivia);
        }
    }
}
