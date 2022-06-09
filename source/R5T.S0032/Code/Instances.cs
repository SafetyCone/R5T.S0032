using System;


namespace R5T.S0032
{
    public static class Instances
    {
        public static F001.IExamples Examples { get; } = F001.Examples.Instance;
        public static B0006.ISyntaxGenerator SyntaxGenerator { get; } = B0006.SyntaxGenerator.Instance;
        public static F0004.SyntaxGenerator SimpleInitialSyntaxGenerator_F0004 { get; } = F0004.SyntaxGenerator.Instance;
        public static Lib.ISyntaxGenerator SimpleInitialSyntaxGenerator_Library { get; } = Lib.SyntaxGenerator.Instance;
        public static Lib.ISyntaxOperator SyntaxOperator_Library { get; } = Lib.SyntaxOperator.Instance;
        public static F001.ISyntaxOperator SyntaxOperator { get; } = F001.SyntaxOperator.Instance;
    }
}
