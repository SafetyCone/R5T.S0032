using System;

using Microsoft.CodeAnalysis;

using R5T.T0132;


namespace R5T.S0032.F001
{
    [DraftFunctionalityMarker]
    public partial interface ISyntaxOperator : IDraftFunctionalityMarker
    {
        public void WriteToExampleCodeFilePath(SyntaxNode node)
        {
            var exampleCodefilePath = Instances.Examples.ExampleCodeFilePath();

            node.WriteToFile_Synchronous(exampleCodefilePath);
        }

        public void WriteToExampleCodeFilePath(SyntaxToken token)
        {
            var exampleCodefilePath = Instances.Examples.ExampleCodeFilePath();

            token.WriteToFile_Synchronous(exampleCodefilePath);
        }

        public void WriteToExampleCodeFilePath(SyntaxTrivia trivia)
        {
            var exampleCodefilePath = Instances.Examples.ExampleCodeFilePath();

            trivia.WriteToFile_Synchronous(exampleCodefilePath);
        }
    }
}
