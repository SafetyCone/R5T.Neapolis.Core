using System;
using System.Text;


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

        private static StringBuilder GetInitialArgumentsBuilder()
        {
            var value = StringArgumentsBuilder.GetInitialArguments();

            var output = new StringBuilder(value);
            return output;
        }

        #endregion


        private StringBuilder ArgumentsBuilder { get; set; } = StringArgumentsBuilder.GetInitialArgumentsBuilder();


        public IArgumentsBuilder AddToken(string token)
        {
            var appendix = $"{Constants.ArgumentTokenSeparator}{token}"; // Note beginning token separator.

            this.ArgumentsBuilder = this.ArgumentsBuilder.Append(appendix);

            return this;
        }

        public string Build()
        {
            var arguments = this.ArgumentsBuilder.ToString();

            return arguments;
        }
    }
}
