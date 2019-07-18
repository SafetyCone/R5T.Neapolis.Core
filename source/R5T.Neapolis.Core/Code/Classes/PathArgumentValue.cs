using System;


namespace R5T.Neapolis
{
    /// <summary>
    /// Encloses paths in double-quotes (prefixed with <see cref="Constants.PathArgumentPrefix"/> and suffixed with <see cref="Constants.PathArgumentSuffix"/>).
    /// </summary>
    public class PathArgumentValue : ArgumentValue
    {
        public PathArgumentValue(string value)
            : base(value)
        {
        }

        public override string GetTokenValue()
        {
            var output = $"{Constants.PathArgumentPrefix}{this.Value}{Constants.PathArgumentSuffix}";
            return output;
        }
    }
}
