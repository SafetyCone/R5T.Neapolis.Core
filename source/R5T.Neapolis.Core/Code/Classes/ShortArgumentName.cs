using System;


namespace R5T.Neapolis
{
    /// <summary>
    /// A short argument name (prefixed with <see cref="Constants.ShortArgumentNamePrefix"/>).
    /// </summary>
    public class ShortArgumentName : ArgumentToken, IArgumentName
    {
        public ShortArgumentName(string name)
            : base(name)
        {
        }

        public override string GetTokenValue()
        {
            var output = $"{Constants.ShortArgumentNamePrefix}{this.Value}";
            return output;
        }
    }
}
