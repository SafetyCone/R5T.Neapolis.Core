using System;


namespace R5T.Neapolis
{
    /// <summary>
    /// Allows building command arguments.
    /// </summary>
    public interface IArgumentsBuilder
    {
        /// <summary>
        /// Adds a token to the arguments string.
        /// </summary>
        void AddToken(string token);

        /// <summary>
        /// Builds the arguments string.
        /// </summary>
        string Build();
    }
}
