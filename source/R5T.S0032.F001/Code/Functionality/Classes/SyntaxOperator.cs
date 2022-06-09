using System;


namespace R5T.S0032.F001
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
