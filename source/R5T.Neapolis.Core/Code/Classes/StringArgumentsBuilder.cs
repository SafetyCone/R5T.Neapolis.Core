using System;

using R5T.NetStandard;


namespace R5T.Neapolis
{
    public class StringArgumentsBuilder : IArgumentsBuilder
    {
        #region Static

        public static string GetInitialArguments()
        {
            var output = String.Empty;
            return output;
        }

        #endregion


        private string Arguments { get; set; } = StringArgumentsBuilder.GetInitialArguments();


        public void AddToken(string token)
        {
            var appendix = $"{Constants.ArgumentTokenSeparator}{token}"; // Note beginning token separator.

            this.Arguments = this.Arguments.Append(appendix);
        }

        public string Build()
        {
            return this.Arguments;
        }
    }
}
