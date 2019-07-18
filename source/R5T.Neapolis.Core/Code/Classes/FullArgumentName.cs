using System;


namespace R5T.Neapolis
{
    /// <summary>
    /// A full (not shortened) argument name (prefixed with <see cref="Constants.FullArgumentNamePrefix"/>).
    /// </summary>
    public class FullArgumentName : ArgumentToken, IArgumentName
    {
        public FullArgumentName(string name)
            : base(name)
        {
        }

        public override string GetTokenValue()
        {
            var output = $"{Constants.FullArgumentNamePrefix}{this.Value}";
            return output;
        }
    }
}
