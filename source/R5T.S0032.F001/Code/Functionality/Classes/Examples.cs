using System;


namespace R5T.S0032.F001
{
    public class Examples : IExamples
    {
        #region Infrastructure

        public static Examples Instance { get; } = new();

        private Examples()
        {
        }

        #endregion
    }
}
