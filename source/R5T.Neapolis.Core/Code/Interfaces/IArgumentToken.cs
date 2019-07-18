using System;


namespace R5T.Neapolis
{
    /// <summary>
    /// A single command-line argument token.
    /// </summary>
    public interface IArgumentToken
    {
        /// <summary>
        /// Gets the command-line token value.
        /// </summary>
        string GetTokenValue();
    }
}
