using System;


namespace R5T.S0032.F001
{
    public static class Instances
    {
        public static IExamples Examples { get; } = F001.Examples.Instance;
        public static ISyntaxOperator SyntaxOperator { get; } = F001.SyntaxOperator.Instance;
    }
}
