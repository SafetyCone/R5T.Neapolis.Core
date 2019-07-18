using System;


namespace R5T.Neapolis
{
    public class NameValueArgument : IArgumentToken
    {
        public IArgumentName Name { get; set; }
        public IArgumentValue Value { get; set; }
        public string TokenSeparator { get; set; }


        public NameValueArgument(string tokenSeparator)
        {
            this.TokenSeparator = tokenSeparator;
        }

        public NameValueArgument()
            : this(Constants.ArgumentTokenSeparator)
        {
        }

        public string GetTokenValue()
        {
            var nameToken = this.Name.GetTokenValue();
            var valueToken = this.Value.GetTokenValue();

            var output = $"{nameToken}{this.TokenSeparator}{valueToken}";
            return output;
        }
    }
}
