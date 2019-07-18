using System;


namespace R5T.Neapolis
{
    public static class ArgumentsBuilder
    {
        public static IArgumentsBuilder New()
        {
            var argumentsBuilder = new StringArgumentsBuilder();
            return argumentsBuilder;
        }
    }
}
