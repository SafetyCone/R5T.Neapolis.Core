using System;


namespace R5T.Neapolis
{
    public interface IVerbArgumentsBuilder : IArgumentsBuilder
    {
        /// <summary>
        /// Returns the main command arguments builder instance.
        /// </summary>
        IArgumentsBuilder Finish();
    }
}
