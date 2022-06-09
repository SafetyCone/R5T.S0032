using System;


namespace R5T.S0032.Lib
{
    public class SyntaxOperator : ISyntaxOperator
    {
        #region Infrastructure

        public static SyntaxOperator Instance { get; } = new();

        private SyntaxOperator()
        {
        }

        #endregion
    }
}
